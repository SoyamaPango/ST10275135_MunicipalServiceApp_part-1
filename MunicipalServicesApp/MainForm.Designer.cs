namespace MunicipalServicesApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.FlowLayoutPanel menuPanel;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnServiceStatus;
        private System.Windows.Forms.Button btnDashboard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnServiceStatus = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();

            // headerPanel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(10, 90, 138);
            this.headerPanel.Controls.Add(this.picLogo);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 100;
            this.headerPanel.Name = "headerPanel";

            // picLogo
            this.picLogo.Image = Properties.Resources.Bayview_flag; // fake flag 
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.Location = new System.Drawing.Point(20, 15);
            this.picLogo.Size = new System.Drawing.Size(70, 70);
            this.picLogo.TabStop = false;

            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(100, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 35);
            this.lblTitle.Text = "Bayview Metropolitan Municipality";

            // lblSubtitle
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.Location = new System.Drawing.Point(102, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(400, 25);
            this.lblSubtitle.Text = "Digital Citizen Services Portal";

            // menuPanel
            this.menuPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuPanel.WrapContents = false;
            this.menuPanel.Padding = new System.Windows.Forms.Padding(20);
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(180, 255, 255, 255);
            this.menuPanel.Size = new System.Drawing.Size(340, 300); 
            this.menuPanel.Location = new System.Drawing.Point(
                (600 - 340) / 2,
                (400 - 300) / 2
            );
            this.menuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPanel.Controls.Add(this.btnReportIssues);
            this.menuPanel.Controls.Add(this.btnEvents);
            this.menuPanel.Controls.Add(this.btnServiceStatus);
            this.menuPanel.Controls.Add(this.btnDashboard);

            // btnReportIssues
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReportIssues.Margin = new System.Windows.Forms.Padding(10);
            this.btnReportIssues.Size = new System.Drawing.Size(300, 50);
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);

            // btnEvents
            this.btnEvents.Text = "Local Events & Announcements";
            this.btnEvents.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEvents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEvents.FlatAppearance.BorderSize = 2;
            this.btnEvents.Margin = new System.Windows.Forms.Padding(10);
            this.btnEvents.Size = new System.Drawing.Size(300, 50);
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);

            // btnServiceStatus
            this.btnServiceStatus.Text = "Service Request Status";
            this.btnServiceStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnServiceStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnServiceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceStatus.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnServiceStatus.FlatAppearance.BorderSize = 2;
            this.btnServiceStatus.Margin = new System.Windows.Forms.Padding(10);
            this.btnServiceStatus.Size = new System.Drawing.Size(300, 50);
            this.btnServiceStatus.Click += new System.EventHandler(this.btnServiceStatus_Click);

            // btnDashboard
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDashboard.FlatAppearance.BorderSize = 2;
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(10);
            this.btnDashboard.Size = new System.Drawing.Size(300, 50);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);

            // MainForm
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = Properties.Resources.gov;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.headerPanel);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
