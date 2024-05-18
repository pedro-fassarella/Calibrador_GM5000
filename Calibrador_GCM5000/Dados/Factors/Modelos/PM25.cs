using Calibrador_GCM5000.Controle;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibrador_GCM5000.Dados.Factors.Modelos
{
    public class PM25
    {
        public DataTable Data { get; set; }

        public PM25(DataTable dadosReferencia, DataTable dadosCalibracao, string colunas)
        {
            string textoColunas = string.Format(colunas, ToString());
            List<string> listColunas = textoColunas.Split(';').ToList();

            Data = DataCleaner.GetDadosDoFator(dadosReferencia, dadosCalibracao, listColunas);
            DataCleaner.LimparAmostrasZeradas(Data, listColunas[1]);
        }

        public override string ToString()
        {
            return base.ToString().Split('.').Last();
        }
    }
}
