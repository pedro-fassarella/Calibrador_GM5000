namespace Calibrador_GCM5000.Views
{
    partial class FrmGraficosDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcGraficos = new TabControl();
            tabCO = new TabPage();
            graficoRegressaoCO = new ScottPlot.WinForms.FormsPlot();
            groupVariaveisCO = new GroupBox();
            lblVlrVarX3CO = new Label();
            lblVarX3CO = new Label();
            lblVlrVarX2CO = new Label();
            lblVarX2CO = new Label();
            lblVlrVarX1CO = new Label();
            lblVarX1CO = new Label();
            lblVlrInterceptCO = new Label();
            lblInterceptCO = new Label();
            groupIntervaloCO = new GroupBox();
            btnCalcularCO = new Button();
            lblFinalCO = new Label();
            lblInicioCO = new Label();
            dateFinalCO = new DateTimePicker();
            dateInicioCO = new DateTimePicker();
            graficoCO = new ScottPlot.WinForms.FormsPlot();
            GridCO = new DataGridView();
            tabO3 = new TabPage();
            groupIntervaloO3 = new GroupBox();
            btnCalcularO3 = new Button();
            lblFinalO3 = new Label();
            lblInicio03 = new Label();
            dateFinalO3 = new DateTimePicker();
            dateInicioO3 = new DateTimePicker();
            graficoO3 = new ScottPlot.WinForms.FormsPlot();
            GridO3 = new DataGridView();
            tabNO2 = new TabPage();
            groupIntervaloNO2 = new GroupBox();
            btnCalcularNO2 = new Button();
            lblFinalNO2 = new Label();
            lblInicioNO2 = new Label();
            dateFinalNO2 = new DateTimePicker();
            dateInicioNO2 = new DateTimePicker();
            graficoNO2 = new ScottPlot.WinForms.FormsPlot();
            GridNO2 = new DataGridView();
            tabSO2 = new TabPage();
            groupIntervaloSO2 = new GroupBox();
            btnCalcularSO2 = new Button();
            lblFinalSO2 = new Label();
            lblInicioSO2 = new Label();
            dateFinalSO2 = new DateTimePicker();
            dateInicioSO2 = new DateTimePicker();
            graficoSO2 = new ScottPlot.WinForms.FormsPlot();
            GridSO2 = new DataGridView();
            tabPM25 = new TabPage();
            groupIntervaloPM25 = new GroupBox();
            btnCalcularPM25 = new Button();
            lblFinalPM25 = new Label();
            lblInicioPM25 = new Label();
            dateFinalPM25 = new DateTimePicker();
            dateInicioPM25 = new DateTimePicker();
            graficoPM25 = new ScottPlot.WinForms.FormsPlot();
            GridPM25 = new DataGridView();
            tabPM10 = new TabPage();
            groupIntervaloPM10 = new GroupBox();
            btnCalcularPM10 = new Button();
            lblFinalPM10 = new Label();
            lblInicioPM10 = new Label();
            dateFinalPM10 = new DateTimePicker();
            dateInicioPM10 = new DateTimePicker();
            graficoPM10 = new ScottPlot.WinForms.FormsPlot();
            GridPM10 = new DataGridView();
            tcGraficos.SuspendLayout();
            tabCO.SuspendLayout();
            groupVariaveisCO.SuspendLayout();
            groupIntervaloCO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridCO).BeginInit();
            tabO3.SuspendLayout();
            groupIntervaloO3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridO3).BeginInit();
            tabNO2.SuspendLayout();
            groupIntervaloNO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridNO2).BeginInit();
            tabSO2.SuspendLayout();
            groupIntervaloSO2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridSO2).BeginInit();
            tabPM25.SuspendLayout();
            groupIntervaloPM25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridPM25).BeginInit();
            tabPM10.SuspendLayout();
            groupIntervaloPM10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridPM10).BeginInit();
            SuspendLayout();
            // 
            // tcGraficos
            // 
            tcGraficos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tcGraficos.Controls.Add(tabCO);
            tcGraficos.Controls.Add(tabO3);
            tcGraficos.Controls.Add(tabNO2);
            tcGraficos.Controls.Add(tabSO2);
            tcGraficos.Controls.Add(tabPM25);
            tcGraficos.Controls.Add(tabPM10);
            tcGraficos.Location = new Point(12, 12);
            tcGraficos.Name = "tcGraficos";
            tcGraficos.SelectedIndex = 0;
            tcGraficos.Size = new Size(1056, 636);
            tcGraficos.TabIndex = 0;
            // 
            // tabCO
            // 
            tabCO.Controls.Add(graficoRegressaoCO);
            tabCO.Controls.Add(groupVariaveisCO);
            tabCO.Controls.Add(groupIntervaloCO);
            tabCO.Controls.Add(graficoCO);
            tabCO.Controls.Add(GridCO);
            tabCO.Location = new Point(4, 24);
            tabCO.Name = "tabCO";
            tabCO.Padding = new Padding(3);
            tabCO.Size = new Size(1048, 608);
            tabCO.TabIndex = 0;
            tabCO.Text = "CO";
            tabCO.UseVisualStyleBackColor = true;
            // 
            // graficoRegressaoCO
            // 
            graficoRegressaoCO.DisplayScale = 1F;
            graficoRegressaoCO.Location = new Point(455, 389);
            graficoRegressaoCO.Name = "graficoRegressaoCO";
            graficoRegressaoCO.Size = new Size(414, 193);
            graficoRegressaoCO.TabIndex = 5;
            graficoRegressaoCO.Visible = false;
            // 
            // groupVariaveisCO
            // 
            groupVariaveisCO.Controls.Add(lblVlrVarX3CO);
            groupVariaveisCO.Controls.Add(lblVarX3CO);
            groupVariaveisCO.Controls.Add(lblVlrVarX2CO);
            groupVariaveisCO.Controls.Add(lblVarX2CO);
            groupVariaveisCO.Controls.Add(lblVlrVarX1CO);
            groupVariaveisCO.Controls.Add(lblVarX1CO);
            groupVariaveisCO.Controls.Add(lblVlrInterceptCO);
            groupVariaveisCO.Controls.Add(lblInterceptCO);
            groupVariaveisCO.Location = new Point(875, 389);
            groupVariaveisCO.Name = "groupVariaveisCO";
            groupVariaveisCO.Size = new Size(167, 193);
            groupVariaveisCO.TabIndex = 4;
            groupVariaveisCO.TabStop = false;
            groupVariaveisCO.Text = "Variáveis";
            groupVariaveisCO.Visible = false;
            // 
            // lblVlrVarX3CO
            // 
            lblVlrVarX3CO.AutoSize = true;
            lblVlrVarX3CO.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVlrVarX3CO.ForeColor = Color.Red;
            lblVlrVarX3CO.Location = new Point(81, 152);
            lblVlrVarX3CO.Name = "lblVlrVarX3CO";
            lblVlrVarX3CO.Size = new Size(47, 20);
            lblVlrVarX3CO.TabIndex = 10;
            lblVlrVarX3CO.Text = "value";
            // 
            // lblVarX3CO
            // 
            lblVarX3CO.AutoSize = true;
            lblVarX3CO.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVarX3CO.Location = new Point(6, 152);
            lblVarX3CO.Name = "lblVarX3CO";
            lblVarX3CO.Size = new Size(60, 20);
            lblVarX3CO.TabIndex = 9;
            lblVarX3CO.Text = "VAR X3:";
            // 
            // lblVlrVarX2CO
            // 
            lblVlrVarX2CO.AutoSize = true;
            lblVlrVarX2CO.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVlrVarX2CO.ForeColor = Color.Red;
            lblVlrVarX2CO.Location = new Point(81, 111);
            lblVlrVarX2CO.Name = "lblVlrVarX2CO";
            lblVlrVarX2CO.Size = new Size(47, 20);
            lblVlrVarX2CO.TabIndex = 8;
            lblVlrVarX2CO.Text = "value";
            // 
            // lblVarX2CO
            // 
            lblVarX2CO.AutoSize = true;
            lblVarX2CO.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVarX2CO.Location = new Point(6, 111);
            lblVarX2CO.Name = "lblVarX2CO";
            lblVarX2CO.Size = new Size(60, 20);
            lblVarX2CO.TabIndex = 7;
            lblVarX2CO.Text = "VAR X2:";
            // 
            // lblVlrVarX1CO
            // 
            lblVlrVarX1CO.AutoSize = true;
            lblVlrVarX1CO.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVlrVarX1CO.ForeColor = Color.Red;
            lblVlrVarX1CO.Location = new Point(81, 69);
            lblVlrVarX1CO.Name = "lblVlrVarX1CO";
            lblVlrVarX1CO.Size = new Size(47, 20);
            lblVlrVarX1CO.TabIndex = 6;
            lblVlrVarX1CO.Text = "value";
            // 
            // lblVarX1CO
            // 
            lblVarX1CO.AutoSize = true;
            lblVarX1CO.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVarX1CO.Location = new Point(6, 69);
            lblVarX1CO.Name = "lblVarX1CO";
            lblVarX1CO.Size = new Size(60, 20);
            lblVarX1CO.TabIndex = 5;
            lblVarX1CO.Text = "VAR X1:";
            // 
            // lblVlrInterceptCO
            // 
            lblVlrInterceptCO.AutoSize = true;
            lblVlrInterceptCO.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblVlrInterceptCO.ForeColor = Color.Red;
            lblVlrInterceptCO.Location = new Point(81, 28);
            lblVlrInterceptCO.Name = "lblVlrInterceptCO";
            lblVlrInterceptCO.Size = new Size(47, 20);
            lblVlrInterceptCO.TabIndex = 4;
            lblVlrInterceptCO.Text = "value";
            // 
            // lblInterceptCO
            // 
            lblInterceptCO.AutoSize = true;
            lblInterceptCO.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInterceptCO.Location = new Point(6, 28);
            lblInterceptCO.Name = "lblInterceptCO";
            lblInterceptCO.Size = new Size(71, 20);
            lblInterceptCO.TabIndex = 3;
            lblInterceptCO.Text = "Intercept:";
            // 
            // groupIntervaloCO
            // 
            groupIntervaloCO.Controls.Add(btnCalcularCO);
            groupIntervaloCO.Controls.Add(lblFinalCO);
            groupIntervaloCO.Controls.Add(lblInicioCO);
            groupIntervaloCO.Controls.Add(dateFinalCO);
            groupIntervaloCO.Controls.Add(dateInicioCO);
            groupIntervaloCO.Location = new Point(455, 291);
            groupIntervaloCO.Name = "groupIntervaloCO";
            groupIntervaloCO.Size = new Size(587, 68);
            groupIntervaloCO.TabIndex = 3;
            groupIntervaloCO.TabStop = false;
            groupIntervaloCO.Text = "Amostras para calibração";
            // 
            // btnCalcularCO
            // 
            btnCalcularCO.Location = new Point(479, 29);
            btnCalcularCO.Name = "btnCalcularCO";
            btnCalcularCO.Size = new Size(102, 23);
            btnCalcularCO.TabIndex = 4;
            btnCalcularCO.Text = "Calcular";
            btnCalcularCO.UseVisualStyleBackColor = true;
            btnCalcularCO.Click += btnCalcularCO_Click;
            // 
            // lblFinalCO
            // 
            lblFinalCO.AutoSize = true;
            lblFinalCO.Location = new Point(239, 35);
            lblFinalCO.Name = "lblFinalCO";
            lblFinalCO.Size = new Size(35, 15);
            lblFinalCO.TabIndex = 3;
            lblFinalCO.Text = "Final:";
            // 
            // lblInicioCO
            // 
            lblInicioCO.AutoSize = true;
            lblInicioCO.Location = new Point(8, 35);
            lblInicioCO.Name = "lblInicioCO";
            lblInicioCO.Size = new Size(39, 15);
            lblInicioCO.TabIndex = 2;
            lblInicioCO.Text = "Inicio:";
            // 
            // dateFinalCO
            // 
            dateFinalCO.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFinalCO.Format = DateTimePickerFormat.Custom;
            dateFinalCO.Location = new Point(280, 29);
            dateFinalCO.Name = "dateFinalCO";
            dateFinalCO.Size = new Size(138, 23);
            dateFinalCO.TabIndex = 1;
            dateFinalCO.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // dateInicioCO
            // 
            dateInicioCO.CustomFormat = "dd/MM/yyyy HH:mm";
            dateInicioCO.Format = DateTimePickerFormat.Custom;
            dateInicioCO.Location = new Point(53, 29);
            dateInicioCO.Name = "dateInicioCO";
            dateInicioCO.Size = new Size(138, 23);
            dateInicioCO.TabIndex = 0;
            dateInicioCO.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // graficoCO
            // 
            graficoCO.DisplayScale = 1F;
            graficoCO.Location = new Point(455, 6);
            graficoCO.Name = "graficoCO";
            graficoCO.Size = new Size(587, 279);
            graficoCO.TabIndex = 2;
            // 
            // GridCO
            // 
            GridCO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridCO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCO.Location = new Point(6, 6);
            GridCO.Name = "GridCO";
            GridCO.RowTemplate.Height = 25;
            GridCO.Size = new Size(443, 596);
            GridCO.TabIndex = 1;
            // 
            // tabO3
            // 
            tabO3.Controls.Add(groupIntervaloO3);
            tabO3.Controls.Add(graficoO3);
            tabO3.Controls.Add(GridO3);
            tabO3.Location = new Point(4, 24);
            tabO3.Name = "tabO3";
            tabO3.Padding = new Padding(3);
            tabO3.Size = new Size(1048, 608);
            tabO3.TabIndex = 1;
            tabO3.Text = "O3";
            tabO3.UseVisualStyleBackColor = true;
            // 
            // groupIntervaloO3
            // 
            groupIntervaloO3.Controls.Add(btnCalcularO3);
            groupIntervaloO3.Controls.Add(lblFinalO3);
            groupIntervaloO3.Controls.Add(lblInicio03);
            groupIntervaloO3.Controls.Add(dateFinalO3);
            groupIntervaloO3.Controls.Add(dateInicioO3);
            groupIntervaloO3.Location = new Point(455, 291);
            groupIntervaloO3.Name = "groupIntervaloO3";
            groupIntervaloO3.Size = new Size(587, 68);
            groupIntervaloO3.TabIndex = 4;
            groupIntervaloO3.TabStop = false;
            groupIntervaloO3.Text = "Amostras para calibração";
            // 
            // btnCalcularO3
            // 
            btnCalcularO3.Location = new Point(479, 29);
            btnCalcularO3.Name = "btnCalcularO3";
            btnCalcularO3.Size = new Size(102, 23);
            btnCalcularO3.TabIndex = 4;
            btnCalcularO3.Text = "Calcular";
            btnCalcularO3.UseVisualStyleBackColor = true;
            // 
            // lblFinalO3
            // 
            lblFinalO3.AutoSize = true;
            lblFinalO3.Location = new Point(239, 35);
            lblFinalO3.Name = "lblFinalO3";
            lblFinalO3.Size = new Size(35, 15);
            lblFinalO3.TabIndex = 3;
            lblFinalO3.Text = "Final:";
            // 
            // lblInicio03
            // 
            lblInicio03.AutoSize = true;
            lblInicio03.Location = new Point(8, 35);
            lblInicio03.Name = "lblInicio03";
            lblInicio03.Size = new Size(39, 15);
            lblInicio03.TabIndex = 2;
            lblInicio03.Text = "Inicio:";
            // 
            // dateFinalO3
            // 
            dateFinalO3.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFinalO3.Format = DateTimePickerFormat.Custom;
            dateFinalO3.Location = new Point(280, 29);
            dateFinalO3.Name = "dateFinalO3";
            dateFinalO3.Size = new Size(138, 23);
            dateFinalO3.TabIndex = 1;
            dateFinalO3.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // dateInicioO3
            // 
            dateInicioO3.CustomFormat = "dd/MM/yyyy HH:mm";
            dateInicioO3.Format = DateTimePickerFormat.Custom;
            dateInicioO3.Location = new Point(53, 29);
            dateInicioO3.Name = "dateInicioO3";
            dateInicioO3.Size = new Size(138, 23);
            dateInicioO3.TabIndex = 0;
            dateInicioO3.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // graficoO3
            // 
            graficoO3.DisplayScale = 1F;
            graficoO3.Location = new Point(455, 6);
            graficoO3.Name = "graficoO3";
            graficoO3.Size = new Size(587, 279);
            graficoO3.TabIndex = 3;
            // 
            // GridO3
            // 
            GridO3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridO3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridO3.Location = new Point(6, 6);
            GridO3.Name = "GridO3";
            GridO3.RowTemplate.Height = 25;
            GridO3.Size = new Size(443, 596);
            GridO3.TabIndex = 0;
            // 
            // tabNO2
            // 
            tabNO2.Controls.Add(groupIntervaloNO2);
            tabNO2.Controls.Add(graficoNO2);
            tabNO2.Controls.Add(GridNO2);
            tabNO2.Location = new Point(4, 24);
            tabNO2.Name = "tabNO2";
            tabNO2.Padding = new Padding(3);
            tabNO2.Size = new Size(1048, 608);
            tabNO2.TabIndex = 2;
            tabNO2.Text = "NO2";
            tabNO2.UseVisualStyleBackColor = true;
            // 
            // groupIntervaloNO2
            // 
            groupIntervaloNO2.Controls.Add(btnCalcularNO2);
            groupIntervaloNO2.Controls.Add(lblFinalNO2);
            groupIntervaloNO2.Controls.Add(lblInicioNO2);
            groupIntervaloNO2.Controls.Add(dateFinalNO2);
            groupIntervaloNO2.Controls.Add(dateInicioNO2);
            groupIntervaloNO2.Location = new Point(455, 291);
            groupIntervaloNO2.Name = "groupIntervaloNO2";
            groupIntervaloNO2.Size = new Size(587, 68);
            groupIntervaloNO2.TabIndex = 4;
            groupIntervaloNO2.TabStop = false;
            groupIntervaloNO2.Text = "Amostras para calibração";
            // 
            // btnCalcularNO2
            // 
            btnCalcularNO2.Location = new Point(479, 29);
            btnCalcularNO2.Name = "btnCalcularNO2";
            btnCalcularNO2.Size = new Size(102, 23);
            btnCalcularNO2.TabIndex = 4;
            btnCalcularNO2.Text = "Calcular";
            btnCalcularNO2.UseVisualStyleBackColor = true;
            // 
            // lblFinalNO2
            // 
            lblFinalNO2.AutoSize = true;
            lblFinalNO2.Location = new Point(239, 35);
            lblFinalNO2.Name = "lblFinalNO2";
            lblFinalNO2.Size = new Size(35, 15);
            lblFinalNO2.TabIndex = 3;
            lblFinalNO2.Text = "Final:";
            // 
            // lblInicioNO2
            // 
            lblInicioNO2.AutoSize = true;
            lblInicioNO2.Location = new Point(8, 35);
            lblInicioNO2.Name = "lblInicioNO2";
            lblInicioNO2.Size = new Size(39, 15);
            lblInicioNO2.TabIndex = 2;
            lblInicioNO2.Text = "Inicio:";
            // 
            // dateFinalNO2
            // 
            dateFinalNO2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFinalNO2.Format = DateTimePickerFormat.Custom;
            dateFinalNO2.Location = new Point(280, 29);
            dateFinalNO2.Name = "dateFinalNO2";
            dateFinalNO2.Size = new Size(138, 23);
            dateFinalNO2.TabIndex = 1;
            dateFinalNO2.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // dateInicioNO2
            // 
            dateInicioNO2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateInicioNO2.Format = DateTimePickerFormat.Custom;
            dateInicioNO2.Location = new Point(53, 29);
            dateInicioNO2.Name = "dateInicioNO2";
            dateInicioNO2.Size = new Size(138, 23);
            dateInicioNO2.TabIndex = 0;
            dateInicioNO2.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // graficoNO2
            // 
            graficoNO2.DisplayScale = 1F;
            graficoNO2.Location = new Point(455, 6);
            graficoNO2.Name = "graficoNO2";
            graficoNO2.Size = new Size(587, 279);
            graficoNO2.TabIndex = 3;
            // 
            // GridNO2
            // 
            GridNO2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridNO2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridNO2.Location = new Point(6, 6);
            GridNO2.Name = "GridNO2";
            GridNO2.RowTemplate.Height = 25;
            GridNO2.Size = new Size(443, 596);
            GridNO2.TabIndex = 1;
            // 
            // tabSO2
            // 
            tabSO2.Controls.Add(groupIntervaloSO2);
            tabSO2.Controls.Add(graficoSO2);
            tabSO2.Controls.Add(GridSO2);
            tabSO2.Location = new Point(4, 24);
            tabSO2.Name = "tabSO2";
            tabSO2.Padding = new Padding(3);
            tabSO2.Size = new Size(1048, 608);
            tabSO2.TabIndex = 3;
            tabSO2.Text = "SO2";
            tabSO2.UseVisualStyleBackColor = true;
            // 
            // groupIntervaloSO2
            // 
            groupIntervaloSO2.Controls.Add(btnCalcularSO2);
            groupIntervaloSO2.Controls.Add(lblFinalSO2);
            groupIntervaloSO2.Controls.Add(lblInicioSO2);
            groupIntervaloSO2.Controls.Add(dateFinalSO2);
            groupIntervaloSO2.Controls.Add(dateInicioSO2);
            groupIntervaloSO2.Location = new Point(455, 291);
            groupIntervaloSO2.Name = "groupIntervaloSO2";
            groupIntervaloSO2.Size = new Size(587, 68);
            groupIntervaloSO2.TabIndex = 4;
            groupIntervaloSO2.TabStop = false;
            groupIntervaloSO2.Text = "Amostras para calibração";
            // 
            // btnCalcularSO2
            // 
            btnCalcularSO2.Location = new Point(479, 29);
            btnCalcularSO2.Name = "btnCalcularSO2";
            btnCalcularSO2.Size = new Size(102, 23);
            btnCalcularSO2.TabIndex = 4;
            btnCalcularSO2.Text = "Calcular";
            btnCalcularSO2.UseVisualStyleBackColor = true;
            // 
            // lblFinalSO2
            // 
            lblFinalSO2.AutoSize = true;
            lblFinalSO2.Location = new Point(239, 35);
            lblFinalSO2.Name = "lblFinalSO2";
            lblFinalSO2.Size = new Size(35, 15);
            lblFinalSO2.TabIndex = 3;
            lblFinalSO2.Text = "Final:";
            // 
            // lblInicioSO2
            // 
            lblInicioSO2.AutoSize = true;
            lblInicioSO2.Location = new Point(8, 35);
            lblInicioSO2.Name = "lblInicioSO2";
            lblInicioSO2.Size = new Size(39, 15);
            lblInicioSO2.TabIndex = 2;
            lblInicioSO2.Text = "Inicio:";
            // 
            // dateFinalSO2
            // 
            dateFinalSO2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFinalSO2.Format = DateTimePickerFormat.Custom;
            dateFinalSO2.Location = new Point(280, 29);
            dateFinalSO2.Name = "dateFinalSO2";
            dateFinalSO2.Size = new Size(138, 23);
            dateFinalSO2.TabIndex = 1;
            dateFinalSO2.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // dateInicioSO2
            // 
            dateInicioSO2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateInicioSO2.Format = DateTimePickerFormat.Custom;
            dateInicioSO2.Location = new Point(53, 29);
            dateInicioSO2.Name = "dateInicioSO2";
            dateInicioSO2.Size = new Size(138, 23);
            dateInicioSO2.TabIndex = 0;
            dateInicioSO2.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // graficoSO2
            // 
            graficoSO2.DisplayScale = 1F;
            graficoSO2.Location = new Point(455, 6);
            graficoSO2.Name = "graficoSO2";
            graficoSO2.Size = new Size(587, 279);
            graficoSO2.TabIndex = 3;
            // 
            // GridSO2
            // 
            GridSO2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridSO2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridSO2.Location = new Point(6, 6);
            GridSO2.Name = "GridSO2";
            GridSO2.RowTemplate.Height = 25;
            GridSO2.Size = new Size(443, 596);
            GridSO2.TabIndex = 1;
            // 
            // tabPM25
            // 
            tabPM25.Controls.Add(groupIntervaloPM25);
            tabPM25.Controls.Add(graficoPM25);
            tabPM25.Controls.Add(GridPM25);
            tabPM25.Location = new Point(4, 24);
            tabPM25.Name = "tabPM25";
            tabPM25.Padding = new Padding(3);
            tabPM25.Size = new Size(1048, 608);
            tabPM25.TabIndex = 4;
            tabPM25.Text = "PM25";
            tabPM25.UseVisualStyleBackColor = true;
            // 
            // groupIntervaloPM25
            // 
            groupIntervaloPM25.Controls.Add(btnCalcularPM25);
            groupIntervaloPM25.Controls.Add(lblFinalPM25);
            groupIntervaloPM25.Controls.Add(lblInicioPM25);
            groupIntervaloPM25.Controls.Add(dateFinalPM25);
            groupIntervaloPM25.Controls.Add(dateInicioPM25);
            groupIntervaloPM25.Location = new Point(455, 291);
            groupIntervaloPM25.Name = "groupIntervaloPM25";
            groupIntervaloPM25.Size = new Size(587, 68);
            groupIntervaloPM25.TabIndex = 4;
            groupIntervaloPM25.TabStop = false;
            groupIntervaloPM25.Text = "Amostras para calibração";
            // 
            // btnCalcularPM25
            // 
            btnCalcularPM25.Location = new Point(479, 29);
            btnCalcularPM25.Name = "btnCalcularPM25";
            btnCalcularPM25.Size = new Size(102, 23);
            btnCalcularPM25.TabIndex = 4;
            btnCalcularPM25.Text = "Calcular";
            btnCalcularPM25.UseVisualStyleBackColor = true;
            // 
            // lblFinalPM25
            // 
            lblFinalPM25.AutoSize = true;
            lblFinalPM25.Location = new Point(239, 35);
            lblFinalPM25.Name = "lblFinalPM25";
            lblFinalPM25.Size = new Size(35, 15);
            lblFinalPM25.TabIndex = 3;
            lblFinalPM25.Text = "Final:";
            // 
            // lblInicioPM25
            // 
            lblInicioPM25.AutoSize = true;
            lblInicioPM25.Location = new Point(8, 35);
            lblInicioPM25.Name = "lblInicioPM25";
            lblInicioPM25.Size = new Size(39, 15);
            lblInicioPM25.TabIndex = 2;
            lblInicioPM25.Text = "Inicio:";
            // 
            // dateFinalPM25
            // 
            dateFinalPM25.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFinalPM25.Format = DateTimePickerFormat.Custom;
            dateFinalPM25.Location = new Point(280, 29);
            dateFinalPM25.Name = "dateFinalPM25";
            dateFinalPM25.Size = new Size(138, 23);
            dateFinalPM25.TabIndex = 1;
            dateFinalPM25.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // dateInicioPM25
            // 
            dateInicioPM25.CustomFormat = "dd/MM/yyyy HH:mm";
            dateInicioPM25.Format = DateTimePickerFormat.Custom;
            dateInicioPM25.Location = new Point(53, 29);
            dateInicioPM25.Name = "dateInicioPM25";
            dateInicioPM25.Size = new Size(138, 23);
            dateInicioPM25.TabIndex = 0;
            dateInicioPM25.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // graficoPM25
            // 
            graficoPM25.DisplayScale = 1F;
            graficoPM25.Location = new Point(455, 6);
            graficoPM25.Name = "graficoPM25";
            graficoPM25.Size = new Size(587, 279);
            graficoPM25.TabIndex = 3;
            // 
            // GridPM25
            // 
            GridPM25.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridPM25.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPM25.Location = new Point(6, 6);
            GridPM25.Name = "GridPM25";
            GridPM25.RowTemplate.Height = 25;
            GridPM25.Size = new Size(443, 596);
            GridPM25.TabIndex = 1;
            // 
            // tabPM10
            // 
            tabPM10.Controls.Add(groupIntervaloPM10);
            tabPM10.Controls.Add(graficoPM10);
            tabPM10.Controls.Add(GridPM10);
            tabPM10.Location = new Point(4, 24);
            tabPM10.Name = "tabPM10";
            tabPM10.Padding = new Padding(3);
            tabPM10.Size = new Size(1048, 608);
            tabPM10.TabIndex = 5;
            tabPM10.Text = "PM10";
            tabPM10.UseVisualStyleBackColor = true;
            // 
            // groupIntervaloPM10
            // 
            groupIntervaloPM10.Controls.Add(btnCalcularPM10);
            groupIntervaloPM10.Controls.Add(lblFinalPM10);
            groupIntervaloPM10.Controls.Add(lblInicioPM10);
            groupIntervaloPM10.Controls.Add(dateFinalPM10);
            groupIntervaloPM10.Controls.Add(dateInicioPM10);
            groupIntervaloPM10.Location = new Point(455, 291);
            groupIntervaloPM10.Name = "groupIntervaloPM10";
            groupIntervaloPM10.Size = new Size(587, 68);
            groupIntervaloPM10.TabIndex = 4;
            groupIntervaloPM10.TabStop = false;
            groupIntervaloPM10.Text = "Amostras para calibração";
            // 
            // btnCalcularPM10
            // 
            btnCalcularPM10.Location = new Point(479, 29);
            btnCalcularPM10.Name = "btnCalcularPM10";
            btnCalcularPM10.Size = new Size(102, 23);
            btnCalcularPM10.TabIndex = 4;
            btnCalcularPM10.Text = "Calcular";
            btnCalcularPM10.UseVisualStyleBackColor = true;
            // 
            // lblFinalPM10
            // 
            lblFinalPM10.AutoSize = true;
            lblFinalPM10.Location = new Point(239, 35);
            lblFinalPM10.Name = "lblFinalPM10";
            lblFinalPM10.Size = new Size(35, 15);
            lblFinalPM10.TabIndex = 3;
            lblFinalPM10.Text = "Final:";
            // 
            // lblInicioPM10
            // 
            lblInicioPM10.AutoSize = true;
            lblInicioPM10.Location = new Point(8, 35);
            lblInicioPM10.Name = "lblInicioPM10";
            lblInicioPM10.Size = new Size(39, 15);
            lblInicioPM10.TabIndex = 2;
            lblInicioPM10.Text = "Inicio:";
            // 
            // dateFinalPM10
            // 
            dateFinalPM10.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFinalPM10.Format = DateTimePickerFormat.Custom;
            dateFinalPM10.Location = new Point(280, 29);
            dateFinalPM10.Name = "dateFinalPM10";
            dateFinalPM10.Size = new Size(138, 23);
            dateFinalPM10.TabIndex = 1;
            dateFinalPM10.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // dateInicioPM10
            // 
            dateInicioPM10.CustomFormat = "dd/MM/yyyy HH:mm";
            dateInicioPM10.Format = DateTimePickerFormat.Custom;
            dateInicioPM10.Location = new Point(53, 29);
            dateInicioPM10.Name = "dateInicioPM10";
            dateInicioPM10.Size = new Size(138, 23);
            dateInicioPM10.TabIndex = 0;
            dateInicioPM10.Value = new DateTime(2024, 5, 18, 17, 0, 0, 0);
            // 
            // graficoPM10
            // 
            graficoPM10.DisplayScale = 1F;
            graficoPM10.Location = new Point(455, 6);
            graficoPM10.Name = "graficoPM10";
            graficoPM10.Size = new Size(587, 279);
            graficoPM10.TabIndex = 3;
            // 
            // GridPM10
            // 
            GridPM10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GridPM10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridPM10.Location = new Point(6, 6);
            GridPM10.Name = "GridPM10";
            GridPM10.RowTemplate.Height = 25;
            GridPM10.Size = new Size(443, 596);
            GridPM10.TabIndex = 1;
            // 
            // FrmGraficosDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 660);
            Controls.Add(tcGraficos);
            Name = "FrmGraficosDados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatores";
            Load += FrmGraficosDados_Load;
            tcGraficos.ResumeLayout(false);
            tabCO.ResumeLayout(false);
            groupVariaveisCO.ResumeLayout(false);
            groupVariaveisCO.PerformLayout();
            groupIntervaloCO.ResumeLayout(false);
            groupIntervaloCO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridCO).EndInit();
            tabO3.ResumeLayout(false);
            groupIntervaloO3.ResumeLayout(false);
            groupIntervaloO3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridO3).EndInit();
            tabNO2.ResumeLayout(false);
            groupIntervaloNO2.ResumeLayout(false);
            groupIntervaloNO2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridNO2).EndInit();
            tabSO2.ResumeLayout(false);
            groupIntervaloSO2.ResumeLayout(false);
            groupIntervaloSO2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridSO2).EndInit();
            tabPM25.ResumeLayout(false);
            groupIntervaloPM25.ResumeLayout(false);
            groupIntervaloPM25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridPM25).EndInit();
            tabPM10.ResumeLayout(false);
            groupIntervaloPM10.ResumeLayout(false);
            groupIntervaloPM10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridPM10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcGraficos;
        private TabPage tabCO;
        private TabPage tabO3;
        private DataGridView GridO3;
        private DataGridView GridCO;
        private TabPage tabNO2;
        private DataGridView GridNO2;
        private TabPage tabSO2;
        private DataGridView GridSO2;
        private TabPage tabPM25;
        private DataGridView GridPM25;
        private TabPage tabPM10;
        private DataGridView GridPM10;
        private ScottPlot.WinForms.FormsPlot graficoCO;
        private ScottPlot.WinForms.FormsPlot graficoO3;
        private ScottPlot.WinForms.FormsPlot graficoNO2;
        private ScottPlot.WinForms.FormsPlot graficoSO2;
        private ScottPlot.WinForms.FormsPlot graficoPM25;
        private ScottPlot.WinForms.FormsPlot graficoPM10;
        private GroupBox groupIntervaloCO;
        private DateTimePicker dateFinalCO;
        private DateTimePicker dateInicioCO;
        private Button btnCalcularCO;
        private Label lblFinalCO;
        private Label lblInicioCO;
        private GroupBox groupIntervaloO3;
        private Button btnCalcularO3;
        private Label lblFinalO3;
        private Label lblInicio03;
        private DateTimePicker dateFinalO3;
        private DateTimePicker dateInicioO3;
        private GroupBox groupIntervaloNO2;
        private Button btnCalcularNO2;
        private Label lblFinalNO2;
        private Label lblInicioNO2;
        private DateTimePicker dateFinalNO2;
        private DateTimePicker dateInicioNO2;
        private GroupBox groupIntervaloSO2;
        private Button btnCalcularSO2;
        private Label lblFinalSO2;
        private Label lblInicioSO2;
        private DateTimePicker dateFinalSO2;
        private DateTimePicker dateInicioSO2;
        private GroupBox groupIntervaloPM25;
        private Button btnCalcularPM25;
        private Label lblFinalPM25;
        private Label lblInicioPM25;
        private DateTimePicker dateFinalPM25;
        private DateTimePicker dateInicioPM25;
        private GroupBox groupIntervaloPM10;
        private Button btnCalcularPM10;
        private Label lblFinalPM10;
        private Label lblInicioPM10;
        private DateTimePicker dateFinalPM10;
        private DateTimePicker dateInicioPM10;
        private GroupBox groupVariaveisCO;
        private ScottPlot.WinForms.FormsPlot graficoRegressaoCO;
        private Label lblVlrInterceptCO;
        private Label lblInterceptCO;
        private Label lblVlrVarX3CO;
        private Label lblVarX3CO;
        private Label lblVlrVarX2CO;
        private Label lblVarX2CO;
        private Label lblVlrVarX1CO;
        private Label lblVarX1CO;
    }
}