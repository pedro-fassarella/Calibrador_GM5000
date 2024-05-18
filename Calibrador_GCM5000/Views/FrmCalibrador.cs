using Calibrador_GCM5000.Controle;
using Calibrador_GCM5000.Dados;
using Calibrador_GCM5000.Views;
using GenericParsing;
using System.Data;
using System.Linq;

namespace Calibrador_GCM5000
{
    public partial class FrmCalibrador : Form
    {
        private string NomeArquivoReferencia { get; set; }
        private DadosReferencia Referencia { get; set; } = new();

        private string NomeArquivoCalibracao { get; set; }
        private DadosCalibracao Calibracao { get; set; } = new();

        private Fatores Fatores { get; set; } = new();

        public FrmCalibrador() => InitializeComponent();

        private void btnAddArquivoCalibrado_Click(object sender, EventArgs e)
        {
            ofdArquivo.ShowDialog();

            if (string.IsNullOrWhiteSpace(ofdArquivo.FileName))
            {
                MessageBox.Show("Escolha o arquivo contendo os dados do equipamento já calibrado",
                    "Calibrador GCM5000", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            NomeArquivoReferencia = ofdArquivo.FileName;
            txtArquivoCalibrado.Text = new FileInfo(NomeArquivoReferencia).Name;
        }

        private void btnAddArquivoCalibracao_Click(object sender, EventArgs e)
        {
            ofdArquivo.ShowDialog();

            if (string.IsNullOrWhiteSpace(ofdArquivo.FileName))
            {
                MessageBox.Show("Escolha o arquivo contendo os dados do equipamento a ser calibrado",
                    "Calibrador GCM5000", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (ofdArquivo.FileName.Equals(NomeArquivoReferencia, StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Arquivo do equipamento a ser calibrado deve ser diferente dos dados já calibrados",
                    "Calibrador GCM5000", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            NomeArquivoCalibracao = ofdArquivo.FileName;
            txtArquivoCalibracao.Text = new FileInfo(NomeArquivoCalibracao).Name;
            btnProcessar.Enabled = true;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Thread tProcessar = new(ProcessarDados)
            {
                Name = "ProcessarDados",
                IsBackground = true
            };

            tProcessar.TrySetApartmentState(ApartmentState.STA);
            tProcessar.Start();

            while (tProcessar.IsAlive) Application.DoEvents();

            Hide();

            using (FrmGraficosDados frm = new(Fatores))
            {
                frm.ShowDialog();
            }

            Show();
        }

        private void ProcessarDados()
        {
            Referencia.SetDados(CSVData.GetDataTableFromFile(NomeArquivoReferencia));
            Calibracao.SetDados(CSVData.GetDataTableFromFile(NomeArquivoCalibracao));
            Fatores.SetDados(Referencia.DtDadosReferencia, Calibracao.DtDadosCalibracao);
        }
    }
}