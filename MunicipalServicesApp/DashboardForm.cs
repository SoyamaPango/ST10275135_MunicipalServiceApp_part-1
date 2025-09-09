using System;
using System.Windows.Forms;
using MunicipalServicesApp.Forms;
using MunicipalServicesApp.Services;

namespace MunisipaServiceApp
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            LoadIssues();
        }

        private void LoadIssues()
        {
            dgvIssues.DataSource = null; // reset binding
            dgvIssues.DataSource = IssueRepository.GetAll(); // bind list
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
