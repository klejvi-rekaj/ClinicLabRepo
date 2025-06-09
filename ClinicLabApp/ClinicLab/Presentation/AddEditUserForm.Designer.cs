namespace ClinicLab.Presentation
{
    partial class AddEditUserForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;

        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(40, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(99, 48);
            lblName.TabIndex = 0;
            lblName.Text = "Emri:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 55);
            txtName.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(40, 106);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(113, 48);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 55);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 173);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(195, 48);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Fjalëkalimi:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(241, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 55);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(40, 252);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(88, 48);
            lblRole.TabIndex = 3;
            lblRole.Text = "Roli:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(154, 244);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(250, 56);
            cmbRole.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(302, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 114);
            btnSave.TabIndex = 4;
            btnSave.Text = "Ruaj";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddEditUserForm
            // 
            ClientSize = new Size(936, 570);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(btnSave);
            Name = "AddEditUserForm";
            Text = "Shto / Ndrysho Përdoruesin";
            Load += AddEditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
