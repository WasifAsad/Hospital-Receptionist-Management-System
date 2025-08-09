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
    public partial class Admin : Form
    {
        private int UserID;
        private string Role;
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public Admin()
        {
            InitializeComponent();
            GetRecord();
        }
        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.[User] where Role='Admin'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            tbUsername.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbNumber.Text = "";
            comboGender.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            tbUsername.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbNumber.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboGender.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Role = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }
        private void UpdateSearchResult(string text)
        {
            using (SqlCommand cmd = new SqlCommand("Select * from dbo.[User] where Role='Admin' and Username LIKE @text", con))
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Clear();
            UpdateSearchResult(tbSearch.Text);
            if(tbSearch.Text=="")
            {
                GetRecord();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserID > 0)
            {
                SqlCommand cmd = new SqlCommand("delete from dbo.[User] where UserID=@UserID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@UserID", this.UserID);
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
            if (UserID > 0)
            {
                SqlCommand cmd = new SqlCommand("Update dbo.[User] set Username=@Username,Email=@Email,ContactNumber=@ContactNumber,Address=@Address,Gender=@Gender,Role=@Role where UserID=@UserID", con);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", tbAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", "Receptionist");
                cmd.Parameters.AddWithValue("@UserID", this.UserID);

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
