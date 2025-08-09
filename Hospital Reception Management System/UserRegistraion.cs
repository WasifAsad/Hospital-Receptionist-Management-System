using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_Reception_Management_System
{
    public partial class UserRegistraion : Form
    {
        string UId;
        public UserRegistraion()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbConfirmPass.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbNumber.Text = "";
            rbAdmin.Checked = false;
            rbRec.Checked = false;
            cbTerms.Checked = false;
        }
        

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool IsPasswordValid(string password)
            {
                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 8 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!password.Any(char.IsUpper))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!password.Any(char.IsLower))
                {
                    MessageBox.Show("Password must contain at least one lowercase letter.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!password.Any(char.IsDigit))
                {
                    MessageBox.Show("Password must contain at least one digit.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (tbUsername.Text==""|| tbPassword.Text == "" || tbConfirmPass.Text == "" || tbEmail.Text == "" || tbAddress.Text == ""||(!rbAdmin.Checked && !rbRec.Checked)||comboGender.Text=="")
            {
                MessageBox.Show("Please Fill Up Form", "SignUp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!cbTerms.Checked) 
            {
                MessageBox.Show("Check Privacy Policy", "SignUp Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else 
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai"))
                {
                    sqlCon.Open();
                    SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.[User] WHERE Email = @Email", sqlCon);
                    checkEmailCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                    int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();

                    if (existingEmailCount > 0)
                    {
                        MessageBox.Show($"{existingEmailCount} account with this email already exists. Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;

                        sqlCmd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Address", tbAddress.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
                        if (rbAdmin.Checked)
                        {
                            sqlCmd.Parameters.AddWithValue("@Role", rbAdmin.Text.Trim());
                        }
                        else
                        {
                            sqlCmd.Parameters.AddWithValue("@Role", rbRec.Text.Trim());
                        }
                        if (!IsPasswordValid(tbPassword.Text))
                        { return; }
                        else
                        {
                            sqlCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("SignUp Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        SqlCommand sqlCmd2 = new SqlCommand("SELECT UserID FROM dbo.[User] WHERE Email = @Email", sqlCon);
                        sqlCmd2.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                        var obj= sqlCmd2.ExecuteScalar();
                        UId = obj.ToString();

                        String to, from, pass;
                        from = "receptionmanagement12@gmail.com";
                        to = tbEmail.Text.Trim();
                        pass = "rhvctikqnnehgpfe";
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.To.Add(to);
                        mailMessage.From = new MailAddress(from);
                        mailMessage.Subject = "Registration Comfoirmation";
                        mailMessage.Body = "Your registration is completed. Your UserID is "+UId+ ". You will need this for further interaction";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        try
                        {
                            smtp.Send(mailMessage);
                            MessageBox.Show("An Email is sent to your Mail Address", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message);
                        }

                        Clear();
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }
    }
}
