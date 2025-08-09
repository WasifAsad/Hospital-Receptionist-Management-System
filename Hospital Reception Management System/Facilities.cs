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
using static System.Net.Mime.MediaTypeNames;

namespace Hospital_Reception_Management_System
{
    public partial class Facilities : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public Facilities()
        {
            InitializeComponent();
            GetDoctor();
            GetNurse();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPatientname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbPId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNurse.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void tbPatientname_TextChanged(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Select PatientID,Patientname,Problem from dbo.[Patient] where Patientname LIKE @text", con))
            {
                cmd.Parameters.AddWithValue("@text", tbPatientname.Text);
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
        private void GetDoctor()
        {
            using (SqlCommand cmd = new SqlCommand("Select DoctorName,Specialist from dbo.[Doctor]", con))
            {
                DataTable dt = new DataTable();
                con.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
                con.Close();
                dataGridView2.DataSource = dt;
            }
        }
        private void GetNurse()
        {
            using (SqlCommand cmd = new SqlCommand("Select NurseID,Name from dbo.[Nurse]", con))
            {
                DataTable dt = new DataTable();
                con.Open();
                using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                {
                    ad.Fill(dt);
                }
                con.Close();
                dataGridView3.DataSource = dt;
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbDoctorName.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbRoom.Checked)
            {
                lblBool.Text = "Yes";
            }
            tbDate.Text = dateTimeAppointment.Text;
            tbPName.Text = tbPatientname.Text;
            tbDName.Text = tbDoctorName.Text;
            tbNname.Text = tbNurse.Text;
        }

        private void Facilities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRecMSDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.hRecMSDataSet.Patient);

        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tbDName.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into dbo.[Patient_Expenses] values(@PatientID,@ExpenceName,@Cost)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PatientID", tbPId.Text.Trim());
                cmd.Parameters.AddWithValue("@ExpenceName", "Doctor");
                cmd.Parameters.AddWithValue("@Cost", 600);
            }
            if (tbNname.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Insert into dbo.[Patient_Expenses] values(@PatientID,@ExpenceName,@Cost)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PatientID", tbPId.Text.Trim());
                cmd.Parameters.AddWithValue("@ExpenceName", "Nurse");
                cmd.Parameters.AddWithValue("@Cost", 500);
            }
            if (lblBool.Text=="Yes")
            {
                SqlCommand cmd = new SqlCommand("Insert into dbo.[Patient_Expenses] values(@PatientID,@ExpenceName,@Cost)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PatientID", tbPId.Text.Trim());
                cmd.Parameters.AddWithValue("@ExpenceName", "Hospital Room");
                cmd.Parameters.AddWithValue("@Cost", 1000);
            }
            tbPId.Text = "";
            tbDName.Text = "";
            tbDoctorName.Text = "";
            tbPatientname.Text = "";
            tbPName.Text = "";
            tbNname.Text = "";
            tbNurse.Text = "";
        }
    }
}
