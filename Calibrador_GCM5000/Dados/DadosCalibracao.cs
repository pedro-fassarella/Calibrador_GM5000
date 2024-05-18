using Calibrador_GCM5000.Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibrador_GCM5000.Dados
{
    public class DadosCalibracao
    {
        public readonly List<string> ColunasCalibracao = new() { "Data", "coFactory", "o3Factory", "no2Factory", "so2Factory", "pm2p5Factory", "pm10Factory", "rh", "sensorTemp" };
        public readonly List<string> ColunasHigienizadas = new() { "Data", "CO", "O3", "NO2", "SO2", "PM25", "PM10", "RH", "Temperatura" };

        public DataTable DtDadosCalibracao;

        public void SetDados(DataTable dtDadosOriginais)
        {
            var dtDadosSemMediaHora = DataCleaner.HigienizarDadosOriginais(dtDadosOriginais, ColunasCalibracao);

            RealizarMediaHora(dtDadosSemMediaHora);

            DataCleaner.RenomearColunas(DtDadosCalibracao, ColunasHigienizadas);
        }

        private void RealizarMediaHora(DataTable dtDadosSemMediaHora)
        {
            DtDadosCalibracao = dtDadosSemMediaHora.Copy();
            DtDadosCalibracao.Clear();

            var dadosAgrupados = DataCleaner.AgruparPorHora(dtDadosSemMediaHora);

            DataCleaner.RealizarMediaHora(dadosAgrupados, DtDadosCalibracao, ColunasCalibracao);
        }
    }
}
