namespace ClinicLab.Presentation
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnManageUsers = new Button();
            btnViewReports = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(30, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(1058, 74);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Mirësevini në Panelin e Administratorit";
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(76, 146);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(423, 100);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Menaxho Përdoruesit";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // btnViewReports
            // 
            btnViewReports.Location = new Point(76, 462);
            btnViewReports.Name = "btnViewReports";
            btnViewReports.Size = new Size(292, 99);
            btnViewReports.TabIndex = 1;
            btnViewReports.Text = "Shiko Raportet";
            btnViewReports.UseVisualStyleBackColor = true;
            btnViewReports.Click += btnViewReports_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(76, 304);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(271, 100);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Konfigurime";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(832, 582);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(200, 100);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Dil";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboardForm
            // 
            ClientSize = new Size(1134, 742);
            Controls.Add(lblWelcome);
            Controls.Add(btnManageUsers);
            Controls.Add(btnViewReports);
            Controls.Add(btnSettings);
            Controls.Add(btnLogout);
            Name = "AdminDashboardForm";
            Text = "Paneli i Administratorit";
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
