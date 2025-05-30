using ClinicLab.Application.BusinessLogic;
using ClinicLab.Application.Models;
using ClinicLab.DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace ClinicLab.Presentation
{
    public partial class PatientForm : Form
    {
        private readonly PatientService _patientService;

        public PatientForm()
        {
            _patientService = new PatientService(new ClinicLabDbContext());

            InitializeComponent();
            SetupDataGridView();  
        }

        private void SetupDataGridView()
        {
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.Columns.Clear();

            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                DataPropertyName = "Id",
                Visible = false
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName"
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName"
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PhoneNumber",
                HeaderText = "Phone",
                DataPropertyName = "PhoneNumber"
            });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email"
            });
        }

        private void LoadPatients()
        {
            var patients = _patientService.GetAllPatients();
            dgvPatients.DataSource = null; 
            dgvPatients.DataSource = patients;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPatients.DataSource = _patientService.SearchPatients(txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PatientEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _patientService.AddPatient(form.Patient);
                    LoadPatients();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;

            var selectedPatient = (Patient)dgvPatients.SelectedRows[0].DataBoundItem;

            using (var form = new PatientEditForm(selectedPatient))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _patientService.UpdatePatient(form.Patient);
                    LoadPatients(); 
                }
            }
        }

        


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0) return;

            var patient = (Patient)dgvPatients.SelectedRows[0].DataBoundItem;

            if (MessageBox.Show($"Delete {patient.FirstName} {patient.LastName}?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _patientService.DeletePatient(patient.Id);
                LoadPatients();
            }
        }
    }
}
