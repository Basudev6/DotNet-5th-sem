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
    public partial class input_10_sum : Form
    {
        public input_10_sum()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nums = txtv1.Text;
            string [] numList=nums.Split(new char[] { ',',' '},StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            foreach(String s in numList)
            {
                sum = sum + Convert.ToInt32(s);
            }
            txtResult.Text = sum.ToString();

            

        }

        private void input_10_sum_Load(object sender, EventArgs e)
        {

        }
    }
}
