namespace ClinicLab.Presentation
{
    partial class PatientForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgvPatients = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(33, 52);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(138, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(225, 52);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(37, 166);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(261, 166);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(160, 166);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Location = new Point(424, 50);
            dgvPatients.Margin = new Padding(3, 4, 3, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 24;
            dgvPatients.Size = new Size(327, 415);
            dgvPatients.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 21);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 6;
            label1.Text = "Search patient";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label1);
            Controls.Add(dgvPatients);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientForm";
            Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvPatients;
        private Label label1;
    }
}
