using Calibrador_GCM5000.Controle;
using Calibrador_GCM5000.Dados.Factors.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibrador_GCM5000.Dados
{
    public class Fatores
    {
        public CO CO { get; set; }
        public O3 O3 { get; set; }
        public NO2 NO2 { get; set; }
        public SO2 SO2 { get; set; }
        public PM25 PM25 { get; set; }
        public PM10 PM10 { get; set; }

        private const string Colunas = "Data;{0}_REF;{0};RH;Temperatura";

        public void SetDados(DataTable dadosReferencia, DataTable dadosCalibracao)
        {
            CO = new(dadosReferencia, dadosCalibracao,Colunas);
            O3 = new(dadosReferencia, dadosCalibracao, Colunas);
            NO2 = new(dadosReferencia, dadosCalibracao, Colunas);
            SO2 = new(dadosReferencia, dadosCalibracao, Colunas);
            PM25 = new(dadosReferencia, dadosCalibracao, Colunas);
            PM10 = new(dadosReferencia, dadosCalibracao, Colunas);
        }
    }
}
