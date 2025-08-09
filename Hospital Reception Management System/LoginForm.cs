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
    public partial class Loginfrm : Form
    {
        private string role;
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void picCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserRegistraion userRegistraion = new UserRegistraion();
            userRegistraion.Owner = this;
            userRegistraion.ShowDialog();
            tbUserId.Text = "";
            tbPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text == "")
            {
                MessageBox.Show("Please Enter UserID ", "Can not Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Can not Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
                    SqlCommand cmd = new SqlCommand("SELECT * from [HRecMS].[dbo].[User] WHERE UserID='" + tbUserId.Text + "' AND Password='" + tbPassword.Text + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        using (SqlCommand scmd = new SqlCommand("Select Role from [HRecMS].[dbo].[User] WHERE UserID='" + tbUserId.Text + "'", con))
                        {
                            con.Open();
                            var obj = scmd.ExecuteScalar();
                            if (obj != null) { role = obj.ToString(); }
                             if (role == "Admin")
                             {
                                 this.Hide();
                                 tbUserId.Text = "";
                                 tbPassword.Text = "";
                                 AdminDashboard adminDashboard = new AdminDashboard();
                                 adminDashboard.Id = tbUserId.Text;
                                 adminDashboard.Owner = this;
                                 adminDashboard.ShowDialog();
                             }
                             else 
                             {
                                this.Hide();
                                tbUserId.Text = "";
                                tbPassword.Text = "";
                                ReceptionistDashboard receptionistDashboard = new ReceptionistDashboard(tbUserId.Text);
                                receptionistDashboard.Owner = this;
                                receptionistDashboard.ShowDialog();
                            }
                             con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ForgortPassword forgortPassword = new ForgortPassword();
            forgortPassword.ShowDialog();
        }
    }
}
