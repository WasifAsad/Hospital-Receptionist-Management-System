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
    public partial class Settings : Form
    {
        internal string Id { get; set; }
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public Settings()
        {
            InitializeComponent();

        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            if(pnlPass.Visible)
            {
                pnlPass.Visible = false;
            }
            panelUsername.Visible = true;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (panelUsername.Visible) 
            {
                panelUsername.Visible = false;
            }
            pnlPass.Visible = true;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmName_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("Update dbo.[User] set Username=@Username where UserID=@ID", con);
            sql.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
            sql.Parameters.AddWithValue("@ID", this.Id);
            int rowsAffected = sql.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows were updated. User with specified ID not found.", "No Rows Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tbUsername.Text = "";
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand("Update dbo.[User] set Password=@Password where UserID=@ID", con);
            sql.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
            sql.Parameters.AddWithValue("@ID", this.Id);
            int rowsAffected = sql.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows were updated. User with specified ID not found.", "No Rows Updated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tbUsername.Text = "";
        }
    }
}
