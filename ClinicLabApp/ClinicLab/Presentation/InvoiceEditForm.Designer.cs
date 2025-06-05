namespace ClinicLab.Presentation
{
    partial class InvoiceEditForm
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
            lblSupplier = new Label();
            lblDate = new Label();
            lblTotal = new Label();
            lblPaid = new Label();
            lblNotes = new Label();
            txtSupplierName = new TextBox();
            dtpInvoiceDate = new DateTimePicker();
            numTotalAmount = new NumericUpDown();
            numAmountPaid = new NumericUpDown();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lblAmountDue = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numTotalAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAmountPaid).BeginInit();
            SuspendLayout();
            // 
            // lblSupplier
            // 
            lblSupplier.Location = new Point(253, 15);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 23);
            lblSupplier.TabIndex = 0;
            lblSupplier.Text = "Supplier";
            // 
            // lblDate
            // 
            lblDate.Location = new Point(28, 223);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 1;
            lblDate.Text = "Invoice Date";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(28, 29);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Price";
            lblTotal.Click += lblTotal_Click;
            // 
            // lblPaid
            // 
            lblPaid.Location = new Point(28, 114);
            lblPaid.Name = "lblPaid";
            lblPaid.Size = new Size(100, 23);
            lblPaid.TabIndex = 3;
            lblPaid.Text = "Amount Paid";
            // 
            // lblNotes
            // 
            lblNotes.Location = new Point(614, 114);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(100, 23);
            lblNotes.TabIndex = 4;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(253, 41);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(142, 27);
            txtSupplierName.TabIndex = 5;
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.Location = new Point(28, 249);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(200, 27);
            dtpInvoiceDate.TabIndex = 6;
            // 
            // numTotalAmount
            // 
            numTotalAmount.Location = new Point(28, 55);
            numTotalAmount.Name = "numTotalAmount";
            numTotalAmount.Size = new Size(120, 27);
            numTotalAmount.TabIndex = 7;
            // 
            // numAmountPaid
            // 
            numAmountPaid.Location = new Point(28, 146);
            numAmountPaid.Name = "numAmountPaid";
            numAmountPaid.Size = new Size(120, 27);
            numAmountPaid.TabIndex = 8;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(253, 114);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(100, 27);
            txtNotes.TabIndex = 9;
            txtNotes.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(458, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 44);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(341, 307);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblAmountDue
            // 
            lblAmountDue.AutoSize = true;
            lblAmountDue.Location = new Point(476, 41);
            lblAmountDue.Name = "lblAmountDue";
            lblAmountDue.Size = new Size(93, 20);
            lblAmountDue.TabIndex = 12;
            lblAmountDue.Text = "Amount Due";
            // 
            // label1
            // 
            label1.Location = new Point(253, 88);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 13;
            label1.Text = "Notes";
            // 
            // InvoiceEditForm
            // 
            ClientSize = new Size(875, 400);
            Controls.Add(label1);
            Controls.Add(lblAmountDue);
            Controls.Add(lblSupplier);
            Controls.Add(lblDate);
            Controls.Add(lblTotal);
            Controls.Add(lblPaid);
            Controls.Add(lblNotes);
            Controls.Add(txtSupplierName);
            Controls.Add(dtpInvoiceDate);
            Controls.Add(numTotalAmount);
            Controls.Add(numAmountPaid);
            Controls.Add(txtNotes);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Invoice";
            ((System.ComponentModel.ISupportInitialize)numTotalAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAmountPaid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Declare Controls (Add these ABOVE InitializeComponent())
        private TextBox txtSupplierName;
        private DateTimePicker dtpInvoiceDate;
        private NumericUpDown numTotalAmount;
        private NumericUpDown numAmountPaid;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;

        #endregion

        private Label lblSupplier;
        private Label lblDate;
        private Label lblTotal;
        private Label lblPaid;
        private Label lblNotes;
        private Label lblAmountDue;
        private Label label1;
    }
}