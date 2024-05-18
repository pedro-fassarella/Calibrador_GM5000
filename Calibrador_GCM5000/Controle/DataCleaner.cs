using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calibrador_GCM5000.Controle
{
    public class DataCleaner
    {
        private static readonly List<string> ColunasTabela = new() { "Data", "NO2", "SO2", "O3", "CO", "PM25", "PM10", "RH", "Temperatura" };

        public static void LimparAmostrasZeradas(DataTable dados, string coluna)
        {
            dados.Rows.Cast<DataRow>().ToList().ForEach(r =>
            {
                if (decimal.Parse(r[coluna].ToString()).Equals(0))
                    dados.Rows.Remove(r);
            });
        }

        public static DataTable HigienizarDadosOriginais(DataTable dtOriginal, List<string> colunasTabela)
        {
            MesclarColunas(dtOriginal, "Data", "localDate", "localTime");

            var tabelaFiltrada = FiltrarDataTable(dtOriginal, colunasTabela);

            ConverterData(tabelaFiltrada);

            return tabelaFiltrada;
        }

        private static void ConverterData(DataTable dtOriginal)
        {
            dtOriginal.Rows.Cast<DataRow>().
                ToList().
                ForEach(r => r["Data"] = DateTime.Parse(r["Data"].ToString()));
        }

        public static List<IGrouping<DateTime, DataRow>> AgruparPorHora(DataTable dtDados)
        {
            return dtDados.AsEnumerable()
            .GroupBy(row =>
            {
                DateTime data = DateTime.Parse(row.Field<string>("Data"));

                if (data.Minute >= 5 || (data.Minute.Equals(0) && data.Hour.Equals(data.Hour + 1)))
                    return data.AddHours(1).AddMinutes(-data.Minute);

                return data.AddMinutes(-data.Minute);
            })
            .ToList();
        }

        public static void RealizarMediaHora(List<IGrouping<DateTime, DataRow>> dadosAgrupados, DataTable dtDados, List<string> colunas)
        {
            dadosAgrupados.ForEach(grupo =>
            {
                string hora = grupo.Key.ToString();
                string mediaCO = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[1]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaO3 = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[2]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaNO2 = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[3]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaSO2 = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[4]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaPM25 = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[5]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaPM10 = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[6]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaRH = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[7]).ToString().Replace(".", ","))).ToString("0.00");
                string mediaTemp = grupo.Average(r => decimal.Parse(r.Field<string>(colunas[8]).ToString().Replace(".", ","))).ToString("0.00");

                object[] parametros = { hora, mediaCO, mediaO3, mediaNO2, mediaSO2, mediaPM25, mediaPM10, mediaRH, mediaTemp };

                dtDados.Rows.Add(parametros);
            });
        }

        public static void MesclarColunas(DataTable dataTable, string newColumnName, string firstColumnName, string secondColumnName)
        {
            dataTable.Columns.Add(newColumnName, typeof(string));

            dataTable.Rows.Cast<DataRow>().
                ToList().
                ForEach(r => r[newColumnName] = r[firstColumnName] + " " + r[secondColumnName]);

            foreach (DataRow row in dataTable.Rows)
                row[newColumnName] = row[firstColumnName] + " " + row[secondColumnName];
        }

        private static DataTable FiltrarDataTable(DataTable originalTable, List<string> columnsToKeep)
        {
            DataTable filteredTable = new();

            columnsToKeep.ForEach(c => filteredTable.Columns.Add(c, originalTable.Columns[c].DataType));

            foreach (DataRow originalRow in originalTable.Rows)
            {
                DataRow newRow = filteredTable.NewRow();
                foreach (string columnName in columnsToKeep)
                    newRow[columnName] = originalRow[columnName];

                filteredTable.Rows.Add(newRow);
            }

            return filteredTable;
        }

        public static void RenomearColunas(DataTable dataTable, List<string> newColumnNames)
        {
            if (dataTable.Columns.Count != newColumnNames.Count)
                throw new ArgumentException("O número de novos nomes de colunas deve ser igual ao número de colunas no DataTable.");

            for (int i = 0; i < dataTable.Columns.Count; i++)
                dataTable.Columns[i].ColumnName = newColumnNames[i];
        }

        public static DataTable GetDadosDoFator(DataTable dadosRef, DataTable dadosCalibracao, List<string> colunasDesejadas)
        {
            DataTable mergedDataTable = new DataTable();

            colunasDesejadas.ForEach(c =>
            {
                if (dadosRef.Columns.Contains(c))
                    mergedDataTable.Columns.Add(c, dadosRef.Columns[c].DataType);

                if (dadosCalibracao.Columns.Contains(c) && !mergedDataTable.Columns.Contains(c))
                    mergedDataTable.Columns.Add(c, dadosCalibracao.Columns[c].DataType);
            });

            foreach (DataRow row1 in dadosRef.Rows)
            {
                DataRow newRow = mergedDataTable.NewRow();

                colunasDesejadas.ForEach(c =>
                {
                    if (dadosRef.Columns.Contains(c))
                        newRow[c] = row1[c];
                });

                DataRow row2 = dadosCalibracao.AsEnumerable().FirstOrDefault(r => r["Data"].ToString().Equals(row1["Data"].ToString()));
                if (row2 is not null)
                {
                    colunasDesejadas.ForEach(c =>
                    {
                        if (string.IsNullOrWhiteSpace(newRow[c].ToString()))
                            newRow[c] = row2[c];
                    });

                }

                mergedDataTable.Rows.Add(newRow);
            }

            return mergedDataTable;
        }

        public static DataTable HigienizarTabelaDados(DataTable dtOriginal)
        {
            DataTable tabelaDadosHig = new();

            DataRow? rowCabecalhos = dtOriginal.Rows.
                Cast<DataRow>().
                ToList().
                Find(r => r.ItemArray.Cast<string>().ToList().Contains("NO2"));

            if (rowCabecalhos is null)
                return null;

            ColunasTabela.ForEach(c => tabelaDadosHig.Columns.Add(c, typeof(string)));

            dtOriginal.Rows.
                Cast<DataRow>().
                ToList().
                ForEach(r =>
                {
                    if (DadosValidos(r))
                        CopyDataRow(r, tabelaDadosHig.NewRow());
                });

            return tabelaDadosHig;
        }

        private static bool DadosValidos(DataRow r)
        {
            if (!DateTime.TryParse(r[0].ToString(), out DateTime result))
                return false;

            if (r[1].ToString().Contains("NoData"))
                return false;

            if (r[1].ToString().Contains("<Samp"))
                return false;

            return true;
        }

        private static void CopyDataRow(DataRow sourceRow, DataRow destinationRow)
        {
            destinationRow.ItemArray = sourceRow.ItemArray;
            destinationRow.Table.Rows.Add(destinationRow);
        }
    }
}