using MathNet.Numerics.LinearRegression;
using System.Data;

namespace Calibrador_GCM5000.Controle
{
    public class CalculadorRLM
    {
        public double[] AmostrasRef { get; private set; }
        public double[] Amostras { get; private set; }

        private double[] RH;
        private double[] Temperatura;
        private int NumeroDeAmostas;

        private string NomeFator;
        private DataTable Dados;
        private DateTime DatInicio;
        private DateTime DatFinal;

        public CalculadorRLM(string nomeFator, DataTable dados, DateTime datInicio, DateTime datFinal)
        {
            NomeFator = nomeFator;
            Dados = dados;
            DatInicio = datInicio;
            DatFinal = datFinal;
        }

        private bool SetDados()
        {
            int iColunaFatorRef = Dados.Columns.IndexOf($"{NomeFator}_REF");
            int iColunaFator = Dados.Columns.IndexOf($"{NomeFator}");
            int iColunaRH = Dados.Columns.IndexOf("RH");
            int iColunaTemperatura = Dados.Columns.IndexOf("Temperatura");

            DataRow[] rows = Dados.Select($"DATA >= '{DatInicio}' AND DATA <= '{DatFinal}'");

            if (rows.Length.Equals(0)) return false;

            NumeroDeAmostas = rows.Length;
            AmostrasRef = rows.Select(r => double.Parse(r.ItemArray[iColunaFatorRef].ToString())).ToArray();
            Amostras = rows.Select(r => double.Parse(r.ItemArray[iColunaFator].ToString())).ToArray();
            RH = rows.Select(r => double.Parse(r.ItemArray[iColunaRH].ToString())).ToArray();
            Temperatura = rows.Select(r => double.Parse(r.ItemArray[iColunaTemperatura].ToString())).ToArray();

            return true;
        }

        public double[] Calcular()
        {
            try
            {
                if (!SetDados()) return null;

                double[][] factors = new double[NumeroDeAmostas][];
                double[] predictor = new double[NumeroDeAmostas];

                for (int i = 0; i < NumeroDeAmostas; i++)
                {
                    factors[i] = new double[] { Amostras[i], Temperatura[i], RH[i] };
                    predictor[i] = AmostrasRef[i];
                }

                return MultipleRegression.QR(factors, predictor, intercept: true);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}