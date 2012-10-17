using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilesIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lnkPickAFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenMyDialog();
        }

        private void OpenMyDialog()
        {
            DialogResult result = ofdPickAFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileIPicked.Text = ofdPickAFile.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!System.IO.File.Exists(txtFileIPicked.Text))
                //{
                //    FileStream fs = File.Create(txtFileIPicked.Text);
                //    fs.Close();
                //}

                StreamWriter sw = new StreamWriter(txtFileIPicked.Text, true);
                sw.Write("Jason was here" + DateTime.Now.ToString() + "\r\n");
                sw.Close();

                StreamReader sr = new StreamReader(txtFileIPicked.Text);
                while (!sr.EndOfStream)
                {
                    MessageBox.Show(sr.ReadLine());
                }
                sr.Close();
            }
            catch (System.ArgumentException ex)
            {
                MessageBox.Show("You must enter a filename!");
            }
            catch (DirectoryNotFoundException ex2)
            {
                throw;
               // MessageBox.Show("The directory you entered was not found!");
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "Open")
            {
                OpenMyDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
