using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TesteWebService
{
    public partial class Form1 : Form
    {
        private DateTime inicio;
        private int NumToProcess;
        private int NumToProcessReverso;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog {Filter = @"mdb|*.mdb"};
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                DataAccess.database = openFileDialog.FileName;
                FillInfo();
            }

            if (Convert.ToInt32(lblProcessados.Text) > 0)
                button3.Enabled = true;

            if (Convert.ToInt32(lblProcessadosReverso.Text) > 0)
                btnExecuteReverso.Enabled = true;
        }

        private void FillInfo()
        {
            DataAccess dataAccess = new DataAccess();
            lblNumTeste.Text = dataAccess.GetCountAllRows().ToString();
            lblProcessados.Text = dataAccess.GetCountRowsToProcess().ToString();

            lblProcessadosReverso.Text = dataAccess.GetCountRowsToProcessReverso().ToString();
            lblNumTesteReverso.Text = dataAccess.GetCountAllRowsReverso().ToString();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblProcessados.Text) > 0 && !String.IsNullOrWhiteSpace(txtUrl.Text))
            {
                DisableForm();
                progressBar1.Maximum = 100;
                //Convert.ToInt32(lblProcessados.Text);
                NumToProcess = Convert.ToInt32(lblProcessados.Text);
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void ProccessDireto()
        {
            var service = new WebService.WebService(txtUrl.Text.Trim());
            var dataAccess = new DataAccess();
            var dataSet = dataAccess.GetDataTableToProcess();
            inicio = DateTime.Now;
            var dataReader = dataSet.Tables[0].CreateDataReader();
            var count = 1;
            backgroundWorker1.WorkerReportsProgress = true;

            while (dataReader.Read())
            {
                try
                {
                    backgroundWorker1.ReportProgress(percent(count));
                    //var result = service.GetResult(dataReader, radioButton1.Checked ? "XML" : "JSON");
                    var result = service.GetResult(dataReader, "JSON");
                    dataAccess.Update(dataReader, result);
                    count++;
                }               
                catch (SystemException ex)
                {
                    continue;
                }
            }
        }

        private void ProccessReverso()
        {
            var service = new WebService.WebServiceReverso(txtUrlReverso.Text.Trim());
            var dataAccess = new DataAccess();
            var dataSet = dataAccess.GetDataTableToProcessReverso();
            inicio = DateTime.Now;
            var dataReader = dataSet.Tables[0].CreateDataReader();
            var count = 1;
            backgroundWorker2.WorkerReportsProgress = true;

            while (dataReader.Read())
            {
                try
                {
                    backgroundWorker2.ReportProgress(percentReverso(count));
                    //var result = service.GetResult(dataReader, rbdXMLReverso.Checked ? "XML" : "JSON");
                    var result = service.GetResult(dataReader, "JSON");
                    dataAccess.UpdateReverso(dataReader, result);
                    count++;
                }
                catch (SystemException ex)
                {
                    continue;
                }
            }
        }


        private int percent(int count)
        {
            return (count * 100) / NumToProcess;
        }

        private int percentReverso(int count)
        {
            return (count * 100) / NumToProcessReverso;
        }

        private void EnableForm()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            btnExecuteReverso.Enabled = true;
            RefreshReverso.Enabled = true;
            rbdJSONReverso.Enabled = true;
            rbdXMLReverso.Enabled = true;
        }

        private void DisableForm()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            btnExecuteReverso.Enabled = false;
            //RefreshReverso.Enabled = false;
            rbdJSONReverso.Enabled = false;
            rbdXMLReverso.Enabled = false;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TimeSpan span = DateTime.Now - inicio;
            lblTempoTotal.Text = span.TotalSeconds.ToString("0.00");
            lblTempoMedio.Text =
                (Convert.ToDecimal(lblTempoTotal.Text) / Convert.ToInt32(lblProcessados.Text)).ToString("0.00");

            EnableForm();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProccessDireto();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((e.ProgressPercentage) >= 100)
                progressBar1.Value = 100;
            else
            {
                progressBar1.Value = e.ProgressPercentage;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FillInfo();
        }

        private void RefreshReverso_Click(object sender, EventArgs e)
        {
            FillInfo();
        }

        private void btnExecuteReverso_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblProcessadosReverso.Text) > 0 && !String.IsNullOrWhiteSpace(txtUrlReverso.Text))
            {
                DisableForm();
                progressBar2.Maximum = 100;
                //Convert.ToInt32(lblProcessados.Text);
                NumToProcessReverso = Convert.ToInt32(lblProcessadosReverso.Text);
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            ProccessReverso();
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((e.ProgressPercentage) >= 100)
                progressBar2.Value = 100;
            else
            {
                progressBar2.Value = e.ProgressPercentage;
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TimeSpan span = DateTime.Now - inicio;
            lblTempoTotalReverso.Text = span.TotalSeconds.ToString("0.00");
            lblTempoMedioReverso.Text =
                (Convert.ToDecimal(lblTempoTotalReverso.Text) / Convert.ToInt32(lblProcessadosReverso.Text)).ToString("0.00");

            EnableForm();
        }
    }
}
