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
    public partial class Checkout : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=ALVI;Initial Catalog=HRecMS;Persist Security Info=True;User ID=sa;Password=janinavai");
        public Checkout()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Select ExpenseName,Cost from dbo.[Patient_Expenses] where PatientID LIKE @text", con))
            {
                cmd.Parameters.AddWithValue("@text", txtPatientid.Text);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
