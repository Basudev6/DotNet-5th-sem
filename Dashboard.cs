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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void sumOfTwoNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sum obj = new sum();
            obj.ShowDialog();
        }

        private void checkPrimeNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            primeCheck obj = new primeCheck();
            obj.ShowDialog();
        }

        private void inputNumbersAndFindSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input_10_sum obj = new input_10_sum();
            obj.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator obj = new calculator();
            obj.ShowDialog();
        }

        private void billingSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billingSoftware obj = new billingSoftware();
            obj.ShowDialog();
        }

        private void billingSoftwareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            billingSoftware obj = new billingSoftware();
            obj.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentData obj = new StudentData();
            obj.ShowDialog();
        }

        private void imageSliderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageSlider obj = new imageSlider();
            obj.ShowDialog();
        }

        private void showImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
