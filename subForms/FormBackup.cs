using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Media;

namespace SistemaPet.subForms
{
    
    public partial class FormBackup : Form
    {

        string pasta_aplicacao = "";


        public FormBackup()
        {
            InitializeComponent();
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }

        public void sound5()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\salvar.wav");
            player.Play();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            sound1();
            progressBar1.Value = 0;
            progressBar1.Maximum = 100000;


            DialogResult result1 = MessageBox.Show("Confirma BACKUP do Sistema Pets&Pets?", "BACKUP?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) 
            {
                

                try
                {
                    DateTime d = DateTime.Now;
                    string dd = d.Day + "-" + d.Month + "-" + d.Year;
                    string servname = ".\\SQLEXPRESS";
                    string dbname = "dbpetsepets";// database name

                    string aaa = @"Data Source=" + servname + ";Integrated Security=True;Initial Catalog=" + dbname + "";
                    SqlConnection con = new SqlConnection(aaa);
                    //con.ConnectionString = ConfigurationManager.ConnectionStrings["BackupCatalogDBSoft.Properties.Settings."+dbname+"ConnectionString"].ToString();

                    con.Open();
                    string str = "USE " + dbname + ";";
                    string str1 = "BACKUP DATABASE " + dbname +
                        " TO DISK = 'C:\\backupdatabase\\" + dbname + "_" + dd +
                        ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of " + dbname + "';";
                    SqlCommand cmd1 = new SqlCommand(str, con);
                    SqlCommand cmd2 = new SqlCommand(str1, con);
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    for (int i = 0; i <= 100000; i++)
                    {
                        progressBar1.Value = i;
                    }

                    
                    if (progressBar1.Value == 100000)
                    {
                        sound5();
                        MessageBox.Show("Backup concluído com sucesso! Você pode encontrar este arquivo (dbpetsepets.Bak) em seu Disco C: \\backupdatabase");
                        con.Close();
                        //this.Close();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            } else { };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound1();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "BAK";
            openFileDialog1.Filter = "Text files (*.bak) | *.bak";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK) 
                {
                textBox1.Text = openFileDialog1.FileName;
            
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sound1();
            progressBar2.Value = 0;
            progressBar2.Maximum = 100000;

            if (textBox1.Text == string.Empty) 
            {
                MessageBox.Show("Selecione primeiro um arquivo para efetuar o Backup-diário!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result1 = MessageBox.Show("Confirma RESTAURAÇÃO DO BACKUP do Sistema Pets&Pets?", "BACKUP?", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                label1.Visible = true;

                string servname = ".\\SQLEXPRESS";
                string dbname = "dbpetsepets";// database name

                string aaa = @"Data Source=" + servname + ";Integrated Security=True;Initial Catalog=" + dbname + "";
                SqlConnection con = new SqlConnection(aaa);
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["BackupCatalogDBSoft.Properties.Settings."+dbname+"ConnectionString"].ToString();

                con.Open();

                string str0 = "USE MASTER";
                string str1 = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str2 = "RESTORE DATABASE " + dbname + " FROM DISK = '" + textBox1.Text + "' WITH REPLACE";

                SqlCommand cmd = new SqlCommand(str0, con);
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlCommand cmd2 = new SqlCommand(str2, con);

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                for (int i = 0; i <= 100000; i++)
                {
                    progressBar2.Value = i;
                }


                if (progressBar2.Value == 100000)
                {
                    
                    sound5();
                    MessageBox.Show("Backup RESTAURADO com sucesso!", "Backup ok!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Visible = false;
                    //MessageBox.Show("NÃO ESQUEÇA DE REALIZAR O BACKUP DIÁRIO AO TÉRMINO DO DIA, SE JÁ REALISOU DESCONSIDERE A MENSAGEM!");
                    con.Close();
                    //this.Close();}

                }
                else { }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sound1();
            textBox1.Text = string.Empty;
            progressBar2.Value = 0;
            if (groupBoxRestore.Visible == false)
            {
                groupBoxRestore.Visible = true;
            }
            else
            {
                groupBoxRestore.Visible = false;
            }
        }
    }
}
