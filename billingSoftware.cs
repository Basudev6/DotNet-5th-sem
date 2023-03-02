using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DesktopApp
{
    public partial class billingSoftware : Form
    {
        private Font verdana10Font;
        private StreamReader reader;
        public billingSoftware()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void billingSoftware_Load(object sender, EventArgs e)
        {
            txtBillNo.Text = GetBillNumber();
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
           
            txtQty.Text = "";
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Add(new string[]{
                (dgvList.Rows.Count+1).ToString(),
                txtItemName.Text,
                txtRate.Value.ToString(),
                txtAmount.Value.ToString()
            });

            // empty text boxes

            txtItemName.Clear();
            txtQty.Value = 1;
            txtRate.Value = 1;
            txtAmount.Value = 1;

            // set focus

            txtItemName.Focus();

            // display total when adding item

            txtTotal.Text = GetTotal().ToString();
        }

        private void txtQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            txtRate.Text = "";
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
 
            txtAmount.Value = txtQty.Value * txtRate.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvList.Rows .Clear();
            txtTotal.Text = "";
            txtDiscount.Text = "";
            txtNetAmount.Text = "";
        }

        decimal GetTotal()
        {
            decimal total = 0;
            for(int i = 0;i<dgvList.Rows.Count;i++ )
            {  
                total = total + Convert.ToDecimal(dgvList.Rows[i].Cells["colAmount"].Value);
            }
            return total;
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtNetAmount_Enter(object sender, EventArgs e)
        {
            if(txtTotal.Text =="" || txtDiscount.Text =="")
            {

            }
            else
            {
                decimal TotalAmount = Convert.ToDecimal(txtTotal.Text);
                decimal Discount = Convert.ToDecimal(txtDiscount.Text);
                txtNetAmount.Text = (TotalAmount - ((TotalAmount * Discount) / 100)).ToString();
            }
            //decimal TotalAmount = Convert.ToDecimal(txtTotal.Text);
            //decimal Discount = Convert.ToDecimal(txtDiscount.Text);
            //txtNetAmount.Text = (TotalAmount - ((TotalAmount * Discount) / 100)).ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SetBillHeader();
            SetBillContent();
            SetBillFooter();
            File.WriteAllText(txtBillNo.Text + ".txt", mybill.Text);


            //print
            string filename = txtBillNo.Text + ".txt";
            //Create a StreamReader object  
            reader = new StreamReader(filename);
            //Create a Verdana font with size 10  
            verdana10Font = new Font("Verdana", 10);
            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();
            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);
            //Call Print Method  
            pd.Print();
            //Close the reader  
            if (reader != null)
                reader.Close();
        }

        private void txtNetAmount_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            /* if(e.KeyCode == Keys.Enter)
             {
                 txtNetAmount.Focus();

             }*/
        }
        private string GetBillNumber()
        {
            string str = DateTime.Now.ToString("ddyyyymmhhss");
            return str;
        }

        private void txtAmount_ValueChanged(object sender, EventArgs e)
        {

        }
        private void SetBillContent()
        {
            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                mybill.Text += dgvList.Rows[i].Cells["colSN"].Value.ToString() + "\t" +
                                dgvList.Rows[i].Cells["colItemName"].Value.ToString()+ "\t\t"+ 
                                dgvList.Rows[i].Cells["colRate"].Value.ToString() + "\t" +
                                dgvList.Rows[i].Cells["colAmount"].Value.ToString();
            }
        }

        private void SetBillHeader()
        {
            mybill.Text = "";
            mybill.Text = "ABC Co. Ltd\nKathmandu\nph:12345\n";
            mybill.Text += "Bill:"+ txtBillNo.Text +"\t Customer Name\n";
            mybill.Text += "Date: "+DateTime.Now.ToString("yyyy-MM-dd")+"\n\n";
            mybill.Text += "Sno\t ItemName\t Rate\t Amount\n\n";
        }

        private void SetBillFooter()
        {
            mybill.Text += "\n\n\t\tThank you for visiting us!!";
        }
        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            //Get the Graphics object  
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            //Read margins from PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            string line = null;
            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / verdana10Font.GetHeight(g);
            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * verdana10Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, verdana10Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        } 

    }


}
