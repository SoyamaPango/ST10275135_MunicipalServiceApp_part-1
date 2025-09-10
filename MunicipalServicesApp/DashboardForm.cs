using System;
using System.Windows.Forms;
using MunicipalServicesApp.Models;
using MunicipalServicesApp.Services;

namespace MunicipalServicesApp.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            ApplyDesign();
            LoadIssues();
        }

        private void ApplyDesign()
        {
            
            this.BackgroundImage = Properties.Resources.gov;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Reported Issues Dashboard";
        }

        private void LoadIssues()
        {
            dgvIssues.DataSource = null;
            dgvIssues.DataSource = IssueRepository.GetAll();

            if (dgvIssues.Columns["AttachmentPath"] != null)
                dgvIssues.Columns["AttachmentPath"].Visible = false;

            if (dgvIssues.Columns["Status"] == null)
                dgvIssues.Columns.Add("Status", "Status");

            dgvIssues.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            if (UserStore.CurrentUser.Role != "Employee")
            {
                MessageBox.Show("Only employees can mark issues as resolved.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvIssues.CurrentRow != null)
            {
                var issue = (Issue)dgvIssues.CurrentRow.DataBoundItem;
                issue.Status = "Resolved";
                dgvIssues.Refresh();
                MessageBox.Show($"Issue '{issue.Category} @ {issue.Location}' marked as resolved.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
