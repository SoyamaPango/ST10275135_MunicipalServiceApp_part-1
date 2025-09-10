namespace MunicipalServicesApp.Forms
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            
            // headerPanel
         
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(10, 90, 138);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Height = 100;
            this.headerPanel.Controls.Add(this.picLogo);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);

        
            // picLogo
           
            this.picLogo.Image = Properties.Resources.Bayview_flag;
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.Location = new System.Drawing.Point(20, 15);
            this.picLogo.Size = new System.Drawing.Size(70, 70);

       
            // lblTitle
         
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(100, 15);
            this.lblTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTitle.Text = "Bayview Metropolitan Municipality";

          
            // lblSubtitle
          
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.Location = new System.Drawing.Point(102, 55);
            this.lblSubtitle.Size = new System.Drawing.Size(400, 25);
            this.lblSubtitle.Text = "Digital Citizen Services Portal";

          
            // lblUsername
           
            this.lblUsername.Location = new System.Drawing.Point(50, 130);
            this.lblUsername.Size = new System.Drawing.Size(80, 23);
            this.lblUsername.Text = "Username:";

           
            // txtUsername
         
            this.txtUsername.Location = new System.Drawing.Point(150, 130);
            this.txtUsername.Size = new System.Drawing.Size(200, 23);

         
            // lblPassword
          
            this.lblPassword.Location = new System.Drawing.Point(50, 170);
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.Text = "Password:";

         
            // txtPassword
          
            this.txtPassword.Location = new System.Drawing.Point(150, 170);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';

          
            // lblRole
          
            this.lblRole.Location = new System.Drawing.Point(50, 210);
            this.lblRole.Size = new System.Drawing.Size(80, 23);
            this.lblRole.Text = "Role:";

          
            // cmbRole
          
            this.cmbRole.Location = new System.Drawing.Point(150, 210);
            this.cmbRole.Size = new System.Drawing.Size(200, 23);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "Resident", "Employee" });

         
            // btnRegister
        
            this.btnRegister.Text = "Register";
            this.btnRegister.Location = new System.Drawing.Point(150, 250);
            this.btnRegister.Size = new System.Drawing.Size(80, 30);
            this.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRegister.FlatAppearance.BorderSize = 2;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

       
            // btnBack
        
            this.btnBack.Text = "Back";
            this.btnBack.Location = new System.Drawing.Point(270, 250);
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

          
            // SignupForm
         
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackgroundImage = Properties.Resources.gov;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
