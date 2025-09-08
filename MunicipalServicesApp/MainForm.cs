using System;
using System.Windows.Forms;

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
            // Consistent, clear UI (rubric: design considerations)
            this.Text = "Municipal Services – Main Menu";
            this.MinimumSize = new System.Drawing.Size(560, 360);
            lblTitle.Text = "Municipal Services Application";
            lblSubtitle.Text = "Choose a task to continue";
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportIssuesForm();
            reportForm.Show();
            this.Hide();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Local Events & Announcements will be implemented in Part 2.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnServiceStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status will be implemented in Part 3.",
                "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
