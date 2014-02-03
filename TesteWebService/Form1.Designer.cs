namespace TesteWebService
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTempoMedio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTempoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblProcessados = new System.Windows.Forms.Label();
            this.lblNumTeste = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtUrlReverso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTempoMedioReverso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTempoTotalReverso = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbdJSONReverso = new System.Windows.Forms.RadioButton();
            this.rbdXMLReverso = new System.Windows.Forms.RadioButton();
            this.btnExecuteReverso = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.RefreshReverso = new System.Windows.Forms.Button();
            this.lblProcessadosReverso = new System.Windows.Forms.Label();
            this.lblNumTesteReverso = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Direto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtUrl);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Location = new System.Drawing.Point(22, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(470, 41);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "WebService";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(70, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(382, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "URL:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTempoMedio);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblTempoTotal);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(20, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 49);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // lblTempoMedio
            // 
            this.lblTempoMedio.AutoSize = true;
            this.lblTempoMedio.Location = new System.Drawing.Point(412, 18);
            this.lblTempoMedio.Name = "lblTempoMedio";
            this.lblTempoMedio.Size = new System.Drawing.Size(0, 13);
            this.lblTempoMedio.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tempo médio de uma requisição (s) : ";
            // 
            // lblTempoTotal
            // 
            this.lblTempoTotal.AutoSize = true;
            this.lblTempoTotal.Location = new System.Drawing.Point(159, 18);
            this.lblTempoTotal.Name = "lblTempoTotal";
            this.lblTempoTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTempoTotal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tempo total dos testes (s) : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(20, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 116);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(11, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formato de Saída: ";
            this.groupBox3.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(294, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "JSON";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "XML";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(373, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Executar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 78);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblProcessados);
            this.groupBox1.Controls.Add(this.lblNumTeste);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info:";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(424, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblProcessados
            // 
            this.lblProcessados.AutoSize = true;
            this.lblProcessados.Location = new System.Drawing.Point(373, 26);
            this.lblProcessados.Name = "lblProcessados";
            this.lblProcessados.Size = new System.Drawing.Size(0, 13);
            this.lblProcessados.TabIndex = 3;
            // 
            // lblNumTeste
            // 
            this.lblNumTeste.AutoSize = true;
            this.lblNumTeste.Location = new System.Drawing.Point(159, 26);
            this.lblNumTeste.Name = "lblNumTeste";
            this.lblNumTeste.Size = new System.Drawing.Size(0, 13);
            this.lblNumTeste.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Testes a serem processados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número total de Testes:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reverso";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtUrlReverso);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Location = new System.Drawing.Point(20, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(470, 41);
            this.groupBox10.TabIndex = 13;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "WebService";
            // 
            // txtUrlReverso
            // 
            this.txtUrlReverso.Location = new System.Drawing.Point(70, 14);
            this.txtUrlReverso.Name = "txtUrlReverso";
            this.txtUrlReverso.Size = new System.Drawing.Size(382, 20);
            this.txtUrlReverso.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "URL:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTempoMedioReverso);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lblTempoTotalReverso);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(20, 242);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(473, 49);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // lblTempoMedioReverso
            // 
            this.lblTempoMedioReverso.AutoSize = true;
            this.lblTempoMedioReverso.Location = new System.Drawing.Point(412, 18);
            this.lblTempoMedioReverso.Name = "lblTempoMedioReverso";
            this.lblTempoMedioReverso.Size = new System.Drawing.Size(0, 13);
            this.lblTempoMedioReverso.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tempo médio de uma requisição (s) : ";
            // 
            // lblTempoTotalReverso
            // 
            this.lblTempoTotalReverso.AutoSize = true;
            this.lblTempoTotalReverso.Location = new System.Drawing.Point(159, 18);
            this.lblTempoTotalReverso.Name = "lblTempoTotalReverso";
            this.lblTempoTotalReverso.Size = new System.Drawing.Size(0, 13);
            this.lblTempoTotalReverso.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tempo total dos testes (s) : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.btnExecuteReverso);
            this.groupBox6.Controls.Add(this.progressBar2);
            this.groupBox6.Location = new System.Drawing.Point(20, 120);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(473, 116);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbdJSONReverso);
            this.groupBox7.Controls.Add(this.rbdXMLReverso);
            this.groupBox7.Location = new System.Drawing.Point(11, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(450, 53);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Formato de Saída: ";
            // 
            // rbdJSONReverso
            // 
            this.rbdJSONReverso.AutoSize = true;
            this.rbdJSONReverso.Location = new System.Drawing.Point(294, 19);
            this.rbdJSONReverso.Name = "rbdJSONReverso";
            this.rbdJSONReverso.Size = new System.Drawing.Size(53, 17);
            this.rbdJSONReverso.TabIndex = 4;
            this.rbdJSONReverso.Text = "JSON";
            this.rbdJSONReverso.UseVisualStyleBackColor = true;
            // 
            // rbdXMLReverso
            // 
            this.rbdXMLReverso.AutoSize = true;
            this.rbdXMLReverso.Checked = true;
            this.rbdXMLReverso.Location = new System.Drawing.Point(103, 19);
            this.rbdXMLReverso.Name = "rbdXMLReverso";
            this.rbdXMLReverso.Size = new System.Drawing.Size(47, 17);
            this.rbdXMLReverso.TabIndex = 3;
            this.rbdXMLReverso.TabStop = true;
            this.rbdXMLReverso.Text = "XML";
            this.rbdXMLReverso.UseVisualStyleBackColor = true;
            // 
            // btnExecuteReverso
            // 
            this.btnExecuteReverso.Enabled = false;
            this.btnExecuteReverso.Image = ((System.Drawing.Image)(resources.GetObject("btnExecuteReverso.Image")));
            this.btnExecuteReverso.Location = new System.Drawing.Point(373, 78);
            this.btnExecuteReverso.Name = "btnExecuteReverso";
            this.btnExecuteReverso.Size = new System.Drawing.Size(88, 23);
            this.btnExecuteReverso.TabIndex = 1;
            this.btnExecuteReverso.Text = "Executar";
            this.btnExecuteReverso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExecuteReverso.UseVisualStyleBackColor = true;
            this.btnExecuteReverso.Click += new System.EventHandler(this.btnExecuteReverso_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(11, 78);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(356, 23);
            this.progressBar2.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.RefreshReverso);
            this.groupBox8.Controls.Add(this.lblProcessadosReverso);
            this.groupBox8.Controls.Add(this.lblNumTesteReverso);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Location = new System.Drawing.Point(20, 53);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(473, 61);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Info:";
            // 
            // RefreshReverso
            // 
            this.RefreshReverso.Image = ((System.Drawing.Image)(resources.GetObject("RefreshReverso.Image")));
            this.RefreshReverso.Location = new System.Drawing.Point(424, 18);
            this.RefreshReverso.Name = "RefreshReverso";
            this.RefreshReverso.Size = new System.Drawing.Size(30, 29);
            this.RefreshReverso.TabIndex = 6;
            this.RefreshReverso.UseVisualStyleBackColor = true;
            this.RefreshReverso.Click += new System.EventHandler(this.RefreshReverso_Click);
            // 
            // lblProcessadosReverso
            // 
            this.lblProcessadosReverso.AutoSize = true;
            this.lblProcessadosReverso.Location = new System.Drawing.Point(373, 26);
            this.lblProcessadosReverso.Name = "lblProcessadosReverso";
            this.lblProcessadosReverso.Size = new System.Drawing.Size(0, 13);
            this.lblProcessadosReverso.TabIndex = 3;
            // 
            // lblNumTesteReverso
            // 
            this.lblNumTesteReverso.AutoSize = true;
            this.lblNumTesteReverso.Location = new System.Drawing.Point(159, 26);
            this.lblNumTesteReverso.Name = "lblNumTesteReverso";
            this.lblNumTesteReverso.Size = new System.Drawing.Size(0, 13);
            this.lblNumTesteReverso.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Testes a serem processados:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Número total de Testes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geocode Service Teste";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(127, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base de Dados: ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblProcessados;
        private System.Windows.Forms.Label lblNumTeste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTempoMedio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTempoTotal;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTempoMedioReverso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTempoTotalReverso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbdJSONReverso;
        private System.Windows.Forms.RadioButton rbdXMLReverso;
        private System.Windows.Forms.Button btnExecuteReverso;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button RefreshReverso;
        private System.Windows.Forms.Label lblProcessadosReverso;
        private System.Windows.Forms.Label lblNumTesteReverso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtUrlReverso;
        private System.Windows.Forms.Label label9;
    }
}

