using System;
using System.IO;
using System.Windows.Forms;
using MunicipalServicesApp.Models;
using MunicipalServicesApp.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalServicesApp.Forms
{
    public partial class ReportIssuesForm : Form
    {
        public ReportIssuesForm()
        {
            InitializeComponent();
            ApplyDesign();
            PopulateCategories();
            ResetEngagement();
        }

        private void ApplyDesign()
        {
            this.Text = "Report Issues";
            this.MinimumSize = new System.Drawing.Size(720, 520); // responsiveness (anchors set in designer)
            lblHeader.Text = "Report an Issue";
            toolTip1.SetToolTip(txtLocation, "Enter the nearest street, suburb, or landmark.");
            toolTip1.SetToolTip(cmbCategory, "Select the category that best matches the issue.");
            toolTip1.SetToolTip(rtbDescription, "Provide a clear, specific description.");
        }

        private void PopulateCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new object[]
            {
                "Sanitation",
                "Roads",
                "Utilities",
                "Parks & Public Spaces",
                "Water & Sewage",
                "Other"
            });
        }

        private void ResetEngagement()
        {
            progressBar.Value = 0;
            lblEngagement.Text = "Tip: Accurate details help resolve issues faster.";
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Attach Image or Document";
                ofd.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Documents (*.pdf;*.docx)|*.pdf;*.docx|All Files (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtAttachment.Text = ofd.FileName;
                    MessageBox.Show("Attachment added.", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                errorProvider1.SetError(txtLocation, "Location is required.");
                ok = false;
            }
            if (cmbCategory.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbCategory, "Please select a category.");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                errorProvider1.SetError(rtbDescription, "Please provide a description.");
                ok = false;
            }

            if (!string.IsNullOrWhiteSpace(txtAttachment.Text))
            {
                try
                {
                    // Lightweight sanity check (file exists)
                    if (!File.Exists(txtAttachment.Text))
                    {
                        errorProvider1.SetError(txtAttachment, "Attachment path is invalid.");
                        ok = false;
                    }
                }
                catch
                {
                    errorProvider1.SetError(txtAttachment, "Attachment path is invalid.");
                    ok = false;
                }
            }

            if (!ok)
            {
                MessageBox.Show("Please fix the highlighted fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ok;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var issue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem?.ToString() ?? "",
                Description = rtbDescription.Text.Trim(),
                AttachmentPath = txtAttachment.Text.Trim()
            };

            Services.IssueRepository.Add(issue);

            // Engagement feature: progress & positive feedback (rubric)
            progressBar.Value = Math.Min(progressBar.Value + 34, 100);
            lblEngagement.Text = $"Thank you! {IssueRepository.Count} issue(s) submitted. You're making a difference.";

            MessageBox.Show("Issue reported successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear inputs for next report
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
            txtAttachment.Clear();
            txtLocation.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var main = new MainForm();
            main.Show();
            this.Close();
        }
    }
}
