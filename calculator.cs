using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString(); // remove zero
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
            txtDisplay.Text = Convert.ToDecimal(txtDisplay.Text).ToString();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            txtDisplay.Text ="0";
            txtOperator.Text = "";
            txtMemory.Text = "";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text = txtDisplay.Text + ".";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length>0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                
            }
            if(txtDisplay.Text.Length==0)
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtMemory.Text = txtDisplay.Text;
            txtDisplay.Text = "0";
            txtOperator.Text = "+";
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtMemory.Text = txtDisplay.Text;
            txtDisplay.Text = "0";
            txtOperator.Text = "-";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtMemory.Text = txtDisplay.Text;
            txtDisplay.Text = "0";
            txtOperator.Text = "*";

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtMemory.Text = txtDisplay.Text;
            txtDisplay.Text = "0";
            txtOperator.Text = "/";

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(txtOperator.Text=="+")
            {
                txtDisplay.Text = (Convert.ToDecimal(txtMemory.Text) + Convert.ToDecimal(txtDisplay.Text)).ToString(); 
            }
            else if(txtOperator.Text == "-")
            {
                txtDisplay.Text = (Convert.ToDecimal(txtMemory.Text) - Convert.ToDecimal(txtDisplay.Text)).ToString();

            }
            else if(txtOperator.Text == "*")
            {
                txtDisplay.Text = (Convert.ToDecimal(txtMemory.Text) * Convert.ToDecimal(txtDisplay.Text)).ToString();

            }
            else if(txtOperator.Text == "/")
            {
                txtDisplay.Text = (Convert.ToDecimal(txtMemory.Text) / Convert.ToDecimal(txtDisplay.Text)).ToString();

            }
            else
            {
                   

            }
        }
    }
}
