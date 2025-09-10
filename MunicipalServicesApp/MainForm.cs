using System;
using System.Windows.Forms;
using MunicipalServicesApp;

namespace MunicipalServicesApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ApplyDesign();
        }

        private void ApplyDesign()
        {
            this.Text = "Bayview Metropolitan Municipality – Main Menu";
            this.MinimumSize = new System.Drawing.Size(600, 400);

            this.BackgroundImage = Properties.Resources.gov;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            lblTitle.Text = "Bayview Metropolitan Municipality";
            lblSubtitle.Text = "Digital Citizen Services Portal";
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportIssuesForm();
            reportForm.Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Local Events & Announcements will be available soon.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status will be available soon.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Hide();
        }
    }
}
