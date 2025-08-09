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
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Reception_Management_System
{
    public partial class AddReceptionist : Form
    {
        private int UserID;
        private string Role,UId,Pass;
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public AddReceptionist()
        {
            InitializeComponent();
            GetRecord();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Clear()
        {
            tbUsername.Text = "";
            tbPassword.Text = ""; 
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbNumber.Text = "";
            comboGender.Text ="" ;
        }
        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from dbo.[User] where Role='Receptionist'", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;
        }


        private void AddReceptionist_Load(object sender, EventArgs e)
        {
            GetRecord();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            tbUsername.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbNumber.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tbPassword.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboGender.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Role=dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = new SqlCommand("Insert into dbo.[User] values(@Username,@Email,@ContactNumber,@Address,@Password, @DateOfBirth,@Gender,@Role)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", tbAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text.Trim());
                cmd.Parameters.AddWithValue("@Gender", comboGender.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", "Receptionist");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SuccessFully Added", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SendMail();
                GetRecord();
                Clear();

            }

            private void label8_Click(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("Update dbo.[User] set Username=@Username,Email=@Email,ContactNumber=@ContactNumber,Address=@Address,Password=@Password,DateOfBirth=@DateOfBirth,Gender=@Gender,Role=@Role where UserID=@UserID", con);
                cmd.Parameters.AddWithValue("@Username", tbUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", tbNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", tbAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", tbPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text.Trim());
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void AddReceptionist_Load_1(object sender, EventArgs e)
        {
            GetRecord();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("Select * from dbo.[User] where Role='Receptionist' and Username LIKE '"+this.tbSearch.Text+"'", con))
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                dataGridView1.DataSource = dt;
            }
            con.Close();
            if (tbSearch.Text=="")
            {
                GetRecord();
            }
        }
        
        private void SendMail()
        {
            SqlCommand sqlCmd2 = new SqlCommand("SELECT UserID FROM dbo.[User] WHERE Email = @Email", con);
            sqlCmd2.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());
            var obj = sqlCmd2.ExecuteScalar();
            UId = obj.ToString();
            Pass = tbPassword.Text.Trim();

            String to, from, pass;
            from = "receptionmanagement12@gmail.com";
            to = tbEmail.Text.Trim();
            pass = "rhvctikqnnehgpfe";
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = "Registration Comfoirmation";
            mailMessage.Body = "Your registration is completed. Your UserID is " + UId + ". And Password is '" + Pass + "'. You will need this for further interaction";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
        }
    }
}
