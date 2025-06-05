using System;
using System.Windows.Forms;
using ClinicLab.DataAccess;
using ClinicLab.Application.BusinessLogic;

namespace ClinicLab.Presentation
{
    public partial class LabWorkerForm : Form
    {
        public LabWorkerForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (var patientForm = new PatientForm())
            {
                patientForm.ShowDialog();
            }
        }

        private void pictureboxInvoices_Click(object sender, EventArgs e)
        {
            using var dbContext = new ClinicLabDbContext();
            var invoiceService = new InvoiceService(dbContext);

            using var invoiceForm = new InvoiceForm(invoiceService);
            invoiceForm.ShowDialog();
        }
    }
}