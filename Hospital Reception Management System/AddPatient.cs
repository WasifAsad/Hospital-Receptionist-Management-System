using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Reception_Management_System
{
    public partial class AddPatient : Form
    {
        private int ID;
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public AddPatient()
        {
            GetRecord();
            InitializeComponent();
            dataGridView1 = new DataGridView();
            dataGridView1.Name = "dataGridView1"; 
            dataGridView1.Dock = DockStyle.Fill;

            Controls.Add(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            tbPatientname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbNumber.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cmbProblem.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            tbEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into dbo.[Patient] values(@Username,@Email,@ContactNumber, @Age,@Problem,@Gender)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", tbPatientname.Text.Trim());
            cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@Age", tbAge.Text.Trim());
            cmd.Parameters.AddWithValue("@Problem", cmbProblem.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SuccessFully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetRecord();
            Clear();
        }
        private void Clear()
        {
            tbPatientname.Text = "";
            tbNumber.Text = "";
            comboGender.Text = "";
            tbAge.Text = "";
            cmbProblem.Text = "";
        }

        private void GetRecord()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai"))
            {
                SqlCommand cmd = new SqlCommand("Select * from dbo.[Patient]", con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from dbo.[User] where NurseID=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                Clear();
            }
            else
            {
                MessageBox.Show("Please Select Information to Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update dbo.[Patient] set PatientName=@Username,Email=@Email,ConatctNumber=@ContactNumber,Age= @Age,Problem=@Problem,Gender=@Gender where PatientID=@ID", con);
                cmd.Parameters.AddWithValue("@Username", tbPatientname.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", tbAge.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Problem", cmbProblem.Text.Trim());
                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated SuccessFully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                Clear();
            }
            else
            {
                MessageBox.Show("Please Select Information to Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
    }
}
