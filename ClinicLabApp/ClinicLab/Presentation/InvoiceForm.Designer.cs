namespace ClinicLab.Presentation
{
    partial class InvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewInvoices = new DataGridView();
            btnAddInvoice = new Button();
            btnEditInvoice = new Button();
            btnDeleteInvoice = new Button();
            label1 = new Label();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            btnFilterExpenses = new Button();
            lblTotalExpenses = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInvoices
            // 
            dataGridViewInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoices.Location = new Point(12, 40);
            dataGridViewInvoices.Name = "dataGridViewInvoices";
            dataGridViewInvoices.RowHeadersWidth = 51;
            dataGridViewInvoices.RowTemplate.Height = 29;
            dataGridViewInvoices.Size = new Size(380, 237);
            dataGridViewInvoices.TabIndex = 1;
            // 
            // btnAddInvoice
            // 
            btnAddInvoice.Location = new Point(44, 346);
            btnAddInvoice.Name = "btnAddInvoice";
            btnAddInvoice.Size = new Size(94, 29);
            btnAddInvoice.TabIndex = 2;
            btnAddInvoice.Text = "Add";
            btnAddInvoice.UseVisualStyleBackColor = true;
            btnAddInvoice.Click += BtnAddInvoice_Click;
            // 
            // btnEditInvoice
            // 
            btnEditInvoice.Location = new Point(186, 346);
            btnEditInvoice.Name = "btnEditInvoice";
            btnEditInvoice.Size = new Size(94, 29);
            btnEditInvoice.TabIndex = 3;
            btnEditInvoice.Text = "Edit";
            btnEditInvoice.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInvoice
            // 
            btnDeleteInvoice.Location = new Point(330, 346);
            btnDeleteInvoice.Name = "btnDeleteInvoice";
            btnDeleteInvoice.Size = new Size(94, 29);
            btnDeleteInvoice.TabIndex = 4;
            btnDeleteInvoice.Text = "Delete";
            btnDeleteInvoice.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 5;
            label1.Text = "Invoice Table";
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(490, 114);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 6;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(490, 178);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 7;
            // 
            // btnFilterExpenses
            // 
            btnFilterExpenses.Location = new Point(573, 347);
            btnFilterExpenses.Name = "btnFilterExpenses";
            btnFilterExpenses.Size = new Size(94, 29);
            btnFilterExpenses.TabIndex = 8;
            btnFilterExpenses.Text = "Filter";
            btnFilterExpenses.UseVisualStyleBackColor = true;
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Location = new Point(499, 274);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(106, 20);
            lblTotalExpenses.TabIndex = 9;
            lblTotalExpenses.Text = "Total Expenses";
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalExpenses);
            Controls.Add(btnFilterExpenses);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Controls.Add(label1);
            Controls.Add(btnDeleteInvoice);
            Controls.Add(btnEditInvoice);
            Controls.Add(btnAddInvoice);
            Controls.Add(dataGridViewInvoices);
            Name = "InvoiceForm";
            Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewInvoices;
        private Button btnAddInvoice;
        private Button btnEditInvoice;
        private Button btnDeleteInvoice;
        private Label label1;
        private DateTimePicker dtpFromDate;
        private DateTimePicker dtpToDate;
        private Button btnFilterExpenses;
        private Label lblTotalExpenses;
    }
}