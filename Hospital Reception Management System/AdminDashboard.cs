using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Reception_Management_System
{
    public partial class AdminDashboard : Form
    {
        public string Id { get; set; }
        public AdminDashboard()
        {
            InitializeComponent();
        }
        

        private void btnReception_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddReceptionist addReceptionist = new AddReceptionist();
            addReceptionist.Owner = this;
            addReceptionist.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNurse addNurse = new AddNurse();
            addNurse.Owner = this;
            addNurse.ShowDialog();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Owner = this;
            addDoctor.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin();
            admin.Owner = this;
            admin.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Id = this.Id;
            settings.ShowDialog();
        }
    }
}
