namespace Calibrador_GCM5000
{
    partial class FrmCalibrador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddArquivoCalibrado=new Button();
            txtArquivoCalibrado=new TextBox();
            btnProcessar=new Button();
            ofdArquivo=new OpenFileDialog();
            txtArquivoCalibracao=new TextBox();
            btnAddArquivoCalibracao=new Button();
            SuspendLayout();
            // 
            // btnAddArquivoCalibrado
            // 
            btnAddArquivoCalibrado.Location=new Point(97, 41);
            btnAddArquivoCalibrado.Name="btnAddArquivoCalibrado";
            btnAddArquivoCalibrado.Size=new Size(213, 23);
            btnAddArquivoCalibrado.TabIndex=0;
            btnAddArquivoCalibrado.Text="Enviar arquivo dados calibrados";
            btnAddArquivoCalibrado.UseVisualStyleBackColor=true;
            btnAddArquivoCalibrado.Click+=btnAddArquivoCalibrado_Click;
            // 
            // txtArquivoCalibrado
            // 
            txtArquivoCalibrado.Enabled=false;
            txtArquivoCalibrado.Location=new Point(12, 12);
            txtArquivoCalibrado.Name="txtArquivoCalibrado";
            txtArquivoCalibrado.ReadOnly=true;
            txtArquivoCalibrado.Size=new Size(298, 23);
            txtArquivoCalibrado.TabIndex=1;
            // 
            // btnProcessar
            // 
            btnProcessar.Location=new Point(196, 157);
            btnProcessar.Name="btnProcessar";
            btnProcessar.Size=new Size(114, 23);
            btnProcessar.TabIndex=2;
            btnProcessar.Text="Processar";
            btnProcessar.UseVisualStyleBackColor=true;
            btnProcessar.Click+=btnProcessar_Click;
            // 
            // ofdArquivo
            // 
            ofdArquivo.Filter="CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm\"";
            // 
            // txtArquivoCalibracao
            // 
            txtArquivoCalibracao.Enabled=false;
            txtArquivoCalibracao.Location=new Point(9, 82);
            txtArquivoCalibracao.Name="txtArquivoCalibracao";
            txtArquivoCalibracao.ReadOnly=true;
            txtArquivoCalibracao.Size=new Size(298, 23);
            txtArquivoCalibracao.TabIndex=4;
            // 
            // btnAddArquivoCalibracao
            // 
            btnAddArquivoCalibracao.Location=new Point(97, 111);
            btnAddArquivoCalibracao.Name="btnAddArquivoCalibracao";
            btnAddArquivoCalibracao.Size=new Size(210, 23);
            btnAddArquivoCalibracao.TabIndex=3;
            btnAddArquivoCalibracao.Text="Enviar arquivo dados para calibração";
            btnAddArquivoCalibracao.UseVisualStyleBackColor=true;
            btnAddArquivoCalibracao.Click+=btnAddArquivoCalibracao_Click;
            // 
            // FrmCalibrador
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(319, 192);
            Controls.Add(txtArquivoCalibracao);
            Controls.Add(btnAddArquivoCalibracao);
            Controls.Add(btnProcessar);
            Controls.Add(txtArquivoCalibrado);
            Controls.Add(btnAddArquivoCalibrado);
            MaximizeBox=false;
            Name="FrmCalibrador";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Calibrador do analisador de gases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddArquivoCalibrado;
        private TextBox txtArquivoCalibrado;
        private Button btnProcessar;
        private OpenFileDialog ofdArquivo;
        private TextBox txtArquivoCalibracao;
        private Button btnAddArquivoCalibracao;
    }
}