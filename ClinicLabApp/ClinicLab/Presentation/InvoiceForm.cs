using ClinicLab.Application.BusinessLogic;
using ClinicLab.Application.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace ClinicLab.Presentation
{
    public partial class InvoiceForm : Form
    {
        private readonly InvoiceService _invoiceService;

        public InvoiceForm(InvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            ConfigureInvoicesDataGridView();
            LoadInvoices();

          
            btnAddInvoice.Click += BtnAddInvoice_Click;
            btnEditInvoice.Click += BtnEditInvoice_Click;
            btnDeleteInvoice.Click += BtnDeleteInvoice_Click;
            btnFilterExpenses.Click += btnFilterExpenses_Click;
        }

        private void ConfigureInvoicesDataGridView()
        {
            dataGridViewInvoices.AutoGenerateColumns = false;
            dataGridViewInvoices.Columns.Clear();

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Width = 80
            });

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SupplierName",
                HeaderText = "Supplier",
                Width = 150
            });

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceDate",
                HeaderText = "Date",
                Width = 100
            });

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AmountPaid",
                HeaderText = "Paid",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AmountDue",
                HeaderText = "Due",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dataGridViewInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Notes",
                HeaderText = "Notes",
                Width = 200
            });
        }


        private void LoadInvoices()
        {
            var invoices = _invoiceService.GetInvoices(); 
            dataGridViewInvoices.DataSource = invoices;
        }




        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            using var invoiceEditForm = new InvoiceEditForm(_invoiceService);
            if (invoiceEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadInvoices();
            }
        }

        private void BtnEditInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.CurrentRow?.DataBoundItem is not Invoice selectedInvoice)
            {
                MessageBox.Show("Please select an invoice to edit.");
                return;
            }

            using var invoiceEditForm = new InvoiceEditForm(_invoiceService, selectedInvoice);
            if (invoiceEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadInvoices();
            }
        }


        private void btnFilterExpenses_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFromDate.Value.Date;
            var toDate = dtpToDate.Value.Date;

            var filteredInvoices = _invoiceService.GetInvoicesByDateRange(fromDate, toDate);
            dataGridViewInvoices.DataSource = filteredInvoices;

            decimal totalExpenses = filteredInvoices.Sum(inv => inv.TotalAmount);
            lblTotalExpenses.Text = $"Total Expenses: {totalExpenses:C}";
        }


        private void BtnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.CurrentRow?.DataBoundItem is not Invoice selectedInvoice)
            {
                MessageBox.Show("Please select an invoice to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this invoice?",
                "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _invoiceService.DeleteInvoice(selectedInvoice.Id);
                LoadInvoices();
            }
        }
    }
}