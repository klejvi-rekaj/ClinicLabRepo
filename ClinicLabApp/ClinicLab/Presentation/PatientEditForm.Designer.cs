namespace ClinicLab.Presentation
{
    partial class PatientEditForm
    {
      
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cboGender = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.AccessibleName = "";
            txtFirstName.Location = new Point(70, 54);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(210, 54);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(70, 115);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(166, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(70, 189);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(70, 260);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 27);
            txtAddress.TabIndex = 4;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(70, 330);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 27);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(70, 396);
            cboGender.Margin = new Padding(3, 4, 3, 4);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(121, 28);
            cboGender.TabIndex = 6;
            cboGender.SelectedIndexChanged += cboGender_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(70, 467);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 372);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 11;
            label4.Text = "Enter Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 306);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 12;
            label5.Text = "Enter Birthdate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 236);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 13;
            label6.Text = "Enter Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 165);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 14;
            label7.Text = "Enter Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 91);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 15;
            label8.Text = "Enter Phone Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(210, 20);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 16;
            label9.Text = "Enter Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 23);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 18;
            label2.Text = "Enter First Name";
            label2.Click += label2_Click;
            // 
            // PatientEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(cboGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientEditForm";
            Text = "PatientEditForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Button btnSave;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label2;
    }
}