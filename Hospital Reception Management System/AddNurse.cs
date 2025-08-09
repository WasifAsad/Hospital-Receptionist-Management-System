using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Reception_Management_System
{
    public partial class AddNurse : Form
    {
        private int ID;
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public AddNurse()
        {
            InitializeComponent();
            GetRecord();
        }
        private void Clear()
        {
            tbNursename.Text = "";
            tbNumber.Text = "";
            comboGender.Text = "";
        }
        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.[Nurse]", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            tbNursename.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbNumber.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into dbo.[Nurse] values(@Username,@ContactNumber, @DateOfBirth,@Gender)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Username", tbNursename.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text.Trim());
            cmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("SuccessFully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetRecord();
            Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update dbo.[Nurse] set Nursename=@Nursename,ContactNumber=@ContactNumber, DateOFBirth=@DateOfBirth,Gender=@Gender where NurseID=@ID", con);
                cmd.Parameters.AddWithValue("@Nursename", tbNursename.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
                cmd.Parameters.AddWithValue("@NurseID", this.ID);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from dbo.[Nurse] where NurseID=@ID", con);
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

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchResult(tbSearch.Text);
            if (tbSearch.Text == "")
            {
                GetRecord();
            }
        }
        private void UpdateSearchResult(string text)
        {
            using (SqlCommand cmd = new SqlCommand("Select * from dbo.[Nurse] where Name LIKE @text", con))
            {
                cmd.Parameters.AddWithValue("@text", text);
                DataTable dt = new DataTable();
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                con.Close();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
