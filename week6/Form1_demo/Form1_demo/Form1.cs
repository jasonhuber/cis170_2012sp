using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1_demo
{
    public partial class Form1 : Form
    {
        bool firstEntry;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtName.Text = "Please enter your name!";
            firstEntry = true;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            picFace.Visible = true;
            lblOutput.Text = txtName.Text;
            if (txtName.Text == "Jason")
            {
                picFace.ImageLocation = "C:\\Users\\Jason\\Desktop\\myface_small_old.jpg";

            }
            else
            {
                picFace.ImageLocation = "C:\\Users\\Jason\\Desktop\\squidward-tentacles_small.gif";
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
          
            if (firstEntry)
            {
                txtName.Text = "";
                firstEntry = false;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            lblOutput.Text = "";
            picFace.Visible = false;
        }

        private void btnStartGuessing_Click(object sender, EventArgs e)
        {
            int range = 100;
            int myGuess = 0;
            bool higher = false;
            bool lower = false;
            int previous = 0;
            int i = 0;
            do
            {
                i++;

                if (myGuess == 0 )
                {
                    myGuess = 50;
                }
                previous = myGuess;
                if (higher)
                {
                    if (previous == 0)
                    {


                        myGuess = ((range - myGuess) / 2) + myGuess;
                    }
                    else
                    {
                        myGuess = myGuess + ((previous - myGuess) / 2);
                    }
                }
                else
                {
                    if (previous == 0)
                    {
                        myGuess = myGuess / 2;
                    }
                    else
                    {
                        myGuess = myGuess - ((myGuess - previous) / 2);
                    }
                    
                }
                
                if (myGuess > int.Parse(txtNum2Guess.Text))
                {
                    lower = true;
                    higher = false;
                }
                else
                {
                    higher = true;
                    lower = false;
                }


            } while (int.Parse(txtNum2Guess.Text) != myGuess || i > 50);
            MessageBox.Show(i.ToString());
        }
              

    }
}
