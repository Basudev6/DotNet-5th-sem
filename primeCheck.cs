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
    public partial class primeCheck : Form
    {
        public primeCheck()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtv1.Text);
            int count = 0;
            for(int i = 2;i<n;i++)
            {
                if(n%i==0)
                {
                    count++;
                    break;
                }
            }
            if(count==1)
            {
                txtResult.Text = "Composite Number";
            }
            else
            {
                txtResult.Text = "Prime Number";
            }
        }

        private void primeCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
