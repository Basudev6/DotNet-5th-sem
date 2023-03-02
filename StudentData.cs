using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopApp
{

    public partial class StudentData : Form
    {

        DataGridViewButtonColumn coledit = new DataGridViewButtonColumn();
        DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
        public StudentData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentData_Load(object sender, EventArgs e)
        {
            dgvStudentInfo.DataSource = GetAllRecord();

            // create add edit column
            coledit.HeaderText = "Edit";
            coledit.MinimumWidth = 6;
            coledit.Name = "Column1";
            coledit.ReadOnly = true;
            coledit.Text = "Edit";
            coledit.UseColumnTextForButtonValue = true;
            coledit.Width = 125;

            // Add column to grid

            dgvStudentInfo.Columns.Add(coledit);

            // create add delete column
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "Column1";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 125;

            // Add column to grid
            dgvStudentInfo.Columns.Add(colDelete);


        }
        private DataTable GetAllRecord()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7; database=DotNetDB;integrated security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblStudentInfo");
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            conn.Close();
            return (dt);


        }
        private void DataInsert()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7; database=DotNetDB;integrated security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblStudentInfo (Name, Email, Age, DOB, Phone, Address, Gender) values (@Name,@Email,@Age,@DOB,@Phone,@Address,@Gender)");
            cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Age", DDAge.Text);
            cmd.Parameters.AddWithValue("@DOB", DPDate.Value);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Gender", CBGender.Text);

            cmd.Connection = conn;

            //execute query

            int ans1 = cmd.ExecuteNonQuery();
            if (ans1 > 0)
                MessageBox.Show("Data saved");
            else
                MessageBox.Show("Data save failed");

        }
        private void DataUpdate()
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7; database=DotNetDB;integrated security=true;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update tblStudentInfo set Name=@Name,Email=@Email,Age=@Age,DOB=@DOB,Phone=@Phone,Address=@Address,Gender=@Gender where Id=@Id");
            cmd.Parameters.AddWithValue("@Id",DDStudentId.Text);
            cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Age", DDAge.Text);
            cmd.Parameters.AddWithValue("@DOB", DPDate.Value);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Gender", CBGender.Text);

            cmd.Connection = conn;

            //execute query

            int ans2 = cmd.ExecuteNonQuery();
            if (ans2 > 0)
                MessageBox.Show("Data updated");
            else
                MessageBox.Show("Data update failed");

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(btnSubmit.Text == "Submit")
            {
                DataInsert();
                dgvStudentInfo.DataSource = GetAllRecord();
            }
            else if(btnSubmit.Text == "Update")
            {
                DataUpdate();
                dgvStudentInfo.DataSource = GetAllRecord();
            }

        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == coledit.Index) // when click on edit what to do
            {

                DDStudentId.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtStudentName.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                DDAge.Value = Convert.ToInt32(dgvStudentInfo.Rows[e.RowIndex].Cells["Age"].Value.ToString());
                DPDate.Value = Convert.ToDateTime(dgvStudentInfo.Rows[e.RowIndex].Cells["DOB"].Value.ToString());
                txtPhone.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                CBGender.Text = dgvStudentInfo.Rows[e.RowIndex].Cells["Gender"].Value.ToString();

                btnSubmit.Text = "Update";

                
            }

            if(e.ColumnIndex == colDelete.Index) // when click on delete what to do
            {
                DialogResult result = MessageBox.Show("Are you sure to delete", "Confirmation",
                                    MessageBoxButtons.YesNo);
                if(result==DialogResult.Yes)
                {

                    SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7; database=DotNetDB;integrated security=true;");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete from tblStudentInfo where Id=@Id");
                    cmd.Parameters.AddWithValue("@Id", dgvStudentInfo.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                    cmd.Connection = conn;

                    //execute query

                    int ans3 = cmd.ExecuteNonQuery();
                    if (ans3 > 0)
                        MessageBox.Show("Data deleted");
                    else
                        MessageBox.Show("Data delete failed");

                    dgvStudentInfo.DataSource = GetAllRecord();
                }
                
            }

         }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            // create the temporary datasource i.e bindingsource because it can filter 
            BindingSource bs = new BindingSource();

            // assign original datasource(i.e) data to binding source
            bs.DataSource = dgvStudentInfo.DataSource;

            // now filter the binding source
            bs.Filter = "Name like '*" + txtSearch.Text + "*'";

            // now assign filtered data in grid
            dgvStudentInfo.DataSource = bs;

            // clear my selection if any on datagrid
            dgvStudentInfo.ClearSelection();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
