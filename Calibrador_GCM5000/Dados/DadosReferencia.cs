using Calibrador_GCM5000.Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibrador_GCM5000.Dados
{
    public class DadosReferencia
    {
        public readonly List<string> ColunasReferencia = new() { "Data", "co", "o3", "no2", "so2", "pm2p5", "pm10", "rh", "sensorTemp" };
        public readonly List<string> ColunasHigienizadas = new() { "Data", "CO_REF", "O3_REF", "NO2_REF", "SO2_REF", "PM25_REF", "PM10_REF", "RH", "Temperatura" };

        public DataTable DtDadosReferencia;

        public void SetDados(DataTable dtDadosOriginais)
        {
            var dtDadosSemMediaHora = DataCleaner.HigienizarDadosOriginais(dtDadosOriginais, ColunasReferencia);

            RealizarMediaHora(dtDadosSemMediaHora);

            DataCleaner.RenomearColunas(DtDadosReferencia, ColunasHigienizadas);
        }

        private void RealizarMediaHora(DataTable dtDadosSemMediaHora)
        {
            DtDadosReferencia = dtDadosSemMediaHora.Copy();
            DtDadosReferencia.Clear();

            var dadosAgrupados = DataCleaner.AgruparPorHora(dtDadosSemMediaHora);

            DataCleaner.RealizarMediaHora(dadosAgrupados, DtDadosReferencia, ColunasReferencia);
        }
    }
}