using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Reception_Management_System
{
    public partial class ForgortPassword : Form
    {
        private string password;
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public ForgortPassword()
        {
            InitializeComponent();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void SendMail()
        {
            SqlCommand cmd = new SqlCommand("Select Password From dbo.[User] Where Email=@Email", con);
            con.Open();
            var obj = cmd.ExecuteScalar();
            if (obj != null) { password = obj.ToString(); }
            cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
            String to, from, pass;
            from = "receptionmanagement12@gmail.com";
            to = tbEmail.Text.Trim();
            pass = "rhvctikqnnehgpfe";
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = "Password Reminder Mail";
            mailMessage.Body = "Your Passwor is'" + password + "'";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmName_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("Select * From dbo.[User] Where Email=@Email ", con);
            sql.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
            con.Open();
            int rowsAffected = sql.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                SendMail();
                MessageBox.Show("An Email is Sent", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Email found.", "No Email Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tbEmail.Text = "";
        }
    }
}
