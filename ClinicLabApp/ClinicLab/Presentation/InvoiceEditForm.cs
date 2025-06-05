using ClinicLab.Application.BusinessLogic;
using ClinicLab.Application.Models;
using System;
using System.Windows.Forms;

namespace ClinicLab.Presentation
{
    public partial class InvoiceEditForm : Form
    {
        private readonly InvoiceService _invoiceService;
        private readonly Invoice _existingInvoice;

       
        public InvoiceEditForm(InvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            SetupForm();
        }

       
        public InvoiceEditForm(InvoiceService invoiceService, Invoice invoice)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            _existingInvoice = invoice;
            SetupForm();
            LoadInvoiceData();
        }

        private void SetupForm()
        {
            dtpInvoiceDate.Value = DateTime.Now;
            numTotalAmount.Value = 0;
            numAmountPaid.Value = 0;
        }

        private void LoadInvoiceData()
        {
            if (_existingInvoice != null)
            {
                txtSupplierName.Text = _existingInvoice.SupplierName;
                dtpInvoiceDate.Value = _existingInvoice.InvoiceDate;

                
                numTotalAmount.Maximum = decimal.MaxValue;  
                numAmountPaid.Maximum = decimal.MaxValue;

                numTotalAmount.Value = _existingInvoice.TotalAmount;
                numAmountPaid.Value = _existingInvoice.AmountPaid;

                txtNotes.Text = _existingInvoice.Notes;

                UpdateAmountDue(); 
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var invoice = _existingInvoice ?? new Invoice();

                invoice.SupplierName = txtSupplierName.Text;
                invoice.InvoiceDate = dtpInvoiceDate.Value;
                invoice.TotalAmount = numTotalAmount.Value;
                invoice.AmountPaid = numAmountPaid.Value;
                invoice.Notes = txtNotes.Text;

                if (_existingInvoice == null)
                    _invoiceService.AddInvoice(invoice);
                else
                    _invoiceService.UpdateInvoice(invoice);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving invoice:\n\n{ex.Message}\n\nDetails:\n{ex.InnerException?.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateAmountDue()
        {
            decimal total = numTotalAmount.Value;
            decimal paid = numAmountPaid.Value;
            lblAmountDue.Text = $"Amount Due: {(total - paid):C}";
        }

        private void numTotalAmount_ValueChanged(object sender, EventArgs e) => UpdateAmountDue();
        private void numAmountPaid_ValueChanged(object sender, EventArgs e) => UpdateAmountDue();


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}