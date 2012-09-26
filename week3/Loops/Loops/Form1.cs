using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            txtNumber.ForeColor = System.Drawing.Color.Black;
            lblOut.Text = "";

            int i = 3;
           /* if (i == 0)
            {
                txtNumber.Text = "1";
            }
            else
            {
                txtNumber.Text = "2";
            }
         
            txtNumber.Text = i == 0 ? "1" : "2";
            */

            double balance = 100.00;
            double checkamount = double.Parse(txtNumber.Text);
            if (checkamount > 200)
            {
                txtNumber.ForeColor = System.Drawing.Color.Red;
                lblOut.Text = "Your check amount cannot be greater than 200!";
            }
            else
            {
                //for (int j = 0; j < 6; j++)
                //{

                //    balance -= checkamount;

                //    MessageBox.Show(balance.ToString());
                //    if (balance <= 0)
                //    {
                //        break;
                //    }
                //    //MessageBox.Show(j.ToString());    
                //}

                //while (balance > 0)
                //{
                //    balance -= checkamount;
                //    MessageBox.Show(balance.ToString());
                //}

                do
                {
                    balance -= checkamount;
                    MessageBox.Show(balance.ToString());
                } while (balance > 0);
            }
        }
    }
}
