using System.Windows.Forms;

namespace MunicipalServicesApp.Forms
{
    partial class DashboardForm : Form 
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnResolve;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.SuspendLayout();
          
            // dgvIssues
         
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Location = new System.Drawing.Point(12, 12);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.Size = new System.Drawing.Size(560, 300);
            this.dgvIssues.TabIndex = 0;
        
            // btnBack
         
            this.btnBack.Location = new System.Drawing.Point(12, 330);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
         
            // btnResolve
        
            this.btnResolve.Location = new System.Drawing.Point(100, 330);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(120, 30);
            this.btnResolve.TabIndex = 2;
            this.btnResolve.Text = "Mark as Resolved";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
        
            // DashboardForm
       
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvIssues);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reported Issues Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
