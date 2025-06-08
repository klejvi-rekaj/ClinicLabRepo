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
            dgvImportPreview = new DataGridView();
            btnImport = new Button();
            pnlImportActions = new Panel();
            ofdImportFile = new OpenFileDialog();
            btnCancelImport = new Button();
            btnConfirmImport = new Button();
            lblImportStatus = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImportPreview).BeginInit();
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
            dgvPatients.Location = new Point(33, 234);
            dgvPatients.Margin = new Padding(3, 4, 3, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.RowTemplate.Height = 24;
            dgvPatients.Size = new Size(395, 258);
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
            // dgvImportPreview
            // 
            dgvImportPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImportPreview.Location = new Point(759, 63);
            dgvImportPreview.Name = "dgvImportPreview";
            dgvImportPreview.RowHeadersWidth = 51;
            dgvImportPreview.RowTemplate.Height = 29;
            dgvImportPreview.Size = new Size(374, 234);
            dgvImportPreview.TabIndex = 7;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(759, 497);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 8;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // pnlImportActions
            // 
            pnlImportActions.Location = new Point(759, 365);
            pnlImportActions.Name = "pnlImportActions";
            pnlImportActions.Size = new Size(182, 78);
            pnlImportActions.TabIndex = 9;
            // 
            // ofdImportFile
            // 
            ofdImportFile.FileName = "openFileDialog1";
            // 
            // btnCancelImport
            // 
            btnCancelImport.Location = new Point(950, 497);
            btnCancelImport.Name = "btnCancelImport";
            btnCancelImport.Size = new Size(94, 29);
            btnCancelImport.TabIndex = 10;
            btnCancelImport.Text = "Cancel";
            btnCancelImport.UseVisualStyleBackColor = true;
            // 
            // btnConfirmImport
            // 
            btnConfirmImport.Location = new Point(1050, 497);
            btnConfirmImport.Name = "btnConfirmImport";
            btnConfirmImport.Size = new Size(94, 29);
            btnConfirmImport.TabIndex = 11;
            btnConfirmImport.Text = "Confirm";
            btnConfirmImport.UseVisualStyleBackColor = true;
            // 
            // lblImportStatus
            // 
            lblImportStatus.AutoSize = true;
            lblImportStatus.Location = new Point(33, 506);
            lblImportStatus.Name = "lblImportStatus";
            lblImportStatus.Size = new Size(0, 20);
            lblImportStatus.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(759, 21);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 13;
            label2.Text = "Import your csv file";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 562);
            Controls.Add(label2);
            Controls.Add(lblImportStatus);
            Controls.Add(btnConfirmImport);
            Controls.Add(btnCancelImport);
            Controls.Add(pnlImportActions);
            Controls.Add(btnImport);
            Controls.Add(dgvImportPreview);
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
            ((System.ComponentModel.ISupportInitialize)dgvImportPreview).EndInit();
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
        private DataGridView dgvImportPreview;
        private Button btnImport;
        private Panel pnlImportActions;
        private OpenFileDialog ofdImportFile;
        private Button btnCancelImport;
        private Button btnConfirmImport;
        private Label lblImportStatus;
        private Label label2;
    }
}
