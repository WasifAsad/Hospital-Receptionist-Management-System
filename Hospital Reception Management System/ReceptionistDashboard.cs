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
    public partial class ReceptionistDashboard : Form
    {
        string ID;
        public ReceptionistDashboard()
        {
            InitializeComponent();
        }
        public ReceptionistDashboard(string ID)
        {
            InitializeComponent();
            this.ID = ID; 
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient patient = new AddPatient();
            patient.Owner = this;
            patient.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btnFacilities_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facilities facilities = new Facilities();
            facilities.Owner = this;
            facilities.ShowDialog();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout checkout = new Checkout();
            checkout.Owner = this;
            checkout.ShowDialog();
        }
    }
}
