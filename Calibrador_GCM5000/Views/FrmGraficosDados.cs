using System.Data;
using ScottPlot;
using ScottPlot.WinForms;
using Calibrador_GCM5000.Dados;
using Calibrador_GCM5000.Controle;
using ScottPlot.Statistics;

namespace Calibrador_GCM5000.Views
{
    public partial class FrmGraficosDados : Form
    {
        private Fatores Fatores { get; set; }

        public FrmGraficosDados(Fatores f)
        {
            Fatores = f;
            InitializeComponent();
        }

        private void FrmGraficosDados_Load(object sender, EventArgs e)
        {
            MontarGraficoFator(Fatores.CO.Data, "CO", "ppm", graficoCO, GridCO);
            MontarGraficoFator(Fatores.O3.Data, "O3", "ppb", graficoO3, GridO3);
            MontarGraficoFator(Fatores.NO2.Data, "NO2", "ppb", graficoNO2, GridNO2);
            MontarGraficoFator(Fatores.SO2.Data, "SO2", "ppb", graficoSO2, GridSO2);
            MontarGraficoFator(Fatores.PM25.Data, "PM25", "ug/m3", graficoPM25, GridPM25);
            MontarGraficoFator(Fatores.PM10.Data, "PM10", "ug/m3", graficoPM10, GridPM10);
        }

        private void MontarGraficoFator(DataTable dtFator, string nomeFator, string unidade, FormsPlot grafico, DataGridView grid)
        {
            grid.DataSource = dtFator;

            double[] listDados = dtFator.Rows.Cast<DataRow>().ToList().Select(r => double.Parse(r[nomeFator].ToString())).ToArray();
            double[] listDados2 = dtFator.Rows.Cast<DataRow>().ToList().Select(r => double.Parse(r[$"{nomeFator}_REF"].ToString())).ToArray();
            double[] listData = dtFator.Rows.Cast<DataRow>().ToList().Select(r => DateTime.Parse(r["Data"].ToString()).ToOADate()).ToArray();

            grafico.Plot.Add.ScatterLine(listData, listDados, Colors.Orange);
            grafico.Plot.Add.ScatterLine(listData, listDados2, Colors.MediumBlue);

            grafico.Plot.Axes.DateTimeTicksBottom();
            grafico.Plot.Axes.AutoScale();
            grafico.Plot.XLabel("Data");
            grafico.Plot.YLabel($"Fatores ({unidade})");
            grafico.Plot.HideGrid();

            grafico.Plot.DataBackground.Color = Colors.LightGray;

            LegendItem item1 = new()
            {
                LineColor = Colors.Orange,
                LineWidth = 2,
                MarkerFillColor = Colors.Orange,
                MarkerLineColor = Colors.Orange,
                LabelText = nomeFator
            };

            LegendItem item2 = new()
            {
                LineColor = Colors.MediumBlue,
                LineWidth = 2,
                MarkerFillColor = Colors.MediumBlue,
                MarkerLineColor = Colors.MediumBlue,
                LabelText = $"{nomeFator}_REF"
            };

            LegendItem[] items = { item1, item2 };
            grafico.Plot.ShowLegend(items);
        }

        private void btnCalcularCO_Click(object sender, EventArgs e) => CalcularRLMCO();

        private void CalcularRLMCO()
        {
            CalculadorRLM c = new(nameof(Fatores.CO), Fatores.CO.Data, dateInicioCO.Value, dateFinalCO.Value);
            var result = c.Calcular();

            if (result is null) return;

            lblVlrInterceptCO.Text = result[0].ToString("0.0000").Replace(",", ".");
            lblVlrVarX1CO.Text = result[1].ToString("0.0000").Replace(",", ".");
            lblVlrVarX2CO.Text = result[2].ToString("0.0000").Replace(",", ".");
            lblVlrVarX3CO.Text = result[3].ToString("0.0000").Replace(",", ".");

            groupVariaveisCO.Visible = true;

            MontarGraficoRegressao(graficoRegressaoCO, c.Amostras, c.AmostrasRef);
        }

        private void MontarGraficoRegressao(FormsPlot grafico, double[] xAmostras, double[] yAmostras)
        {
            grafico.Plot.Clear();

            var sp = grafico.Plot.Add.Scatter(xAmostras, yAmostras, Colors.MediumBlue);
            sp.LineWidth = 0;
            sp.MarkerSize = 7;

            LinearRegression reg = new(xAmostras, yAmostras);
            Coordinates pt1 = new(xAmostras.First(), reg.GetValue(xAmostras.First()));
            Coordinates pt2 = new(xAmostras.Last(), reg.GetValue(xAmostras.Last()));

            var line = grafico.Plot.Add.Line(pt1, pt2);
            line.MarkerSize = 0;
            line.Color = Colors.Orange;
            line.LinePattern = LinePattern.Solid;

            grafico.Plot.Title("Regressão Linear (Factory x Referência)");

            grafico.Visible = true;
            grafico.Refresh();
        }
    }
}
