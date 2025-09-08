namespace MunicipalServicesApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnServiceStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(65, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Municipal Services Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.Location = new System.Drawing.Point(185, 70);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(177, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Choose a task to continue";
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.Location = new System.Drawing.Point(160, 120);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(220, 40);
            this.btnReportIssues.TabIndex = 2;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEvents.Enabled = false; // rubric: disable future tasks
            this.btnEvents.Location = new System.Drawing.Point(160, 175);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(220, 36);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "Local Events & Announcements";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnServiceStatus
            // 
            this.btnServiceStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnServiceStatus.Enabled = false; // rubric: disable future tasks
            this.btnServiceStatus.Location = new System.Drawing.Point(160, 220);
            this.btnServiceStatus.Name = "btnServiceStatus";
            this.btnServiceStatus.Size = new System.Drawing.Size(220, 36);
            this.btnServiceStatus.TabIndex = 4;
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.UseVisualStyleBackColor = true;
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 311);
            this.Controls.Add(this.btnServiceStatus);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnReportIssues);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
