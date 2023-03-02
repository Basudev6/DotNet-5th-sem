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
    public partial class sum : Form
    {
        public sum()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(txtv1.Text);
            float b = Convert.ToSingle(txtv2.Text);
            float c = a + b;
            txtResult.Text = c.ToString();
        }

        private void sum_Load(object sender, EventArgs e)
        {

        }
    }
}
