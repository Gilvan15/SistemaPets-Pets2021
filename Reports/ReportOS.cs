﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.Reports
{
    public partial class ReportOS : Form
    {
        string pasta_aplicacao = "";
        DateTime data1;
        DateTime data2;
        public ReportOS()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }
        private void ReportOS_Load(object sender, EventArgs e)
        {
            carregarDataeLista();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }
        private void carregarDataeLista()
        {
            try
            {

                data1 = DateTime.Parse("1/1/1753");
                data2 = DateTime.Parse("31/12/9999");
                this.oservicoTableAdapter.Fill(this.dbpetsepetsDataSet.Oservico, Convert.ToString(data1), Convert.ToString(data2));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sound1();
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                dateTimePicker1.Focus();
            }
            else
            {
                panel1.Visible = false;
                carregarDataeLista();
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {

            try
            {
                data1 = dateTimePicker1.Value;
                data2 = dateTimePicker2.Value;
                this.oservicoTableAdapter.Fill(this.dbpetsepetsDataSet.Oservico, Convert.ToString(data1), Convert.ToString(data2));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
            

        }
    }
}
