namespace MunicipalServicesApp.Forms
{
    partial class ReportIssuesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblEngagement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblEngagement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // lblHeader
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(140, 20);
            this.lblHeader.Text = "Report an Issue";

            // lblLocation
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(30, 70);
            this.lblLocation.Text = "Location:";

            // txtLocation
            this.txtLocation.Location = new System.Drawing.Point(120, 67);
            this.txtLocation.Size = new System.Drawing.Size(300, 23);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(30, 110);
            this.lblCategory.Text = "Category:";

            // cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
                "Water",
                "Electricity",
                "Roads",
                "Waste Management",
                "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(120, 107);
            this.cmbCategory.Size = new System.Drawing.Size(300, 23);

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 150);
            this.lblDescription.Text = "Description:";

            // rtbDescription
            this.rtbDescription.Location = new System.Drawing.Point(120, 147);
            this.rtbDescription.Size = new System.Drawing.Size(300, 80);

            // lblAttachment
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(30, 240);
            this.lblAttachment.Text = "Attachment:";

            // txtAttachment
            this.txtAttachment.Location = new System.Drawing.Point(120, 237);
            this.txtAttachment.ReadOnly = true;
            this.txtAttachment.Size = new System.Drawing.Size(220, 23);

            // btnAttach
            this.btnAttach.Text = "Browse";
            this.btnAttach.Location = new System.Drawing.Point(350, 236);
            this.btnAttach.Size = new System.Drawing.Size(70, 25);
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);

            // btnSubmit
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(120, 280);
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // btnBack
            this.btnBack.Text = "Back";
            this.btnBack.Location = new System.Drawing.Point(320, 280);
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(120, 330);
            this.progressBar.Size = new System.Drawing.Size(300, 20);

            // lblEngagement
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.Location = new System.Drawing.Point(30, 330);
            this.lblEngagement.Text = "Engagement:";

            // ReportIssuesForm
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtAttachment);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHeader);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issues";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
