using ClinicLab.Application.BusinessLogic;
using System.IO;
using System.Globalization;
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


            btnImport.Click += btnImport_Click;
            btnConfirmImport.Click += btnConfirmImport_Click;
            btnCancelImport.Click += btnCancelImport_Click;
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



            private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                ofd.Title = "Select CSV File to Import";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        List<Patient> importedPatients = ReadPatientsFromCsv(ofd.FileName);
                        if (importedPatients.Count > 0)
                        {
                            ShowImportPreview(importedPatients);
                        }
                        else
                        {
                            MessageBox.Show("No valid patient data found in the CSV file.",
                                          "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error importing CSV: {ex.Message}",
                                      "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private List<Patient> ReadPatientsFromCsv(string filePath)
        {
            List<Patient> patients = new List<Patient>();

            
            string[] lines = File.ReadAllLines(filePath);

           
            int startRow = lines.Length > 0 && lines[0].Contains("FirstName") ? 1 : 0;

            for (int i = startRow; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

               
                if (fields.Length >= 2 && !string.IsNullOrWhiteSpace(fields[0]) && !string.IsNullOrWhiteSpace(fields[1]))
                {
                    try
                    {
                        var patient = new Patient
                        {
                            FirstName = fields[0].Trim(),
                            LastName = fields[1].Trim(),
                            PhoneNumber = fields.Length > 2 ? fields[2].Trim() : "",
                            Email = fields.Length > 3 ? fields[3].Trim() : "",
                            Address = fields.Length > 4 ? fields[4].Trim() : "",
                            Gender = fields.Length > 5 ? fields[5].Trim() : "Other",
                            DateOfBirth = fields.Length > 6 ? ParseDate(fields[6].Trim()) : DateTime.Now.AddYears(-30)
                        };

                        patients.Add(patient);
                    }
                    catch (Exception ex)
                    {
                        
                        Console.WriteLine($"Error processing row {i + 1}: {ex.Message}");
                    }
                }
            }

            return patients;
        }

        private DateTime ParseDate(string dateString)
        {
            if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                return result;
            }
            return DateTime.Now.AddYears(-30); 
        }

        private void ShowImportPreview(List<Patient> patients)
        {
            
            dgvImportPreview.AutoGenerateColumns = false;
            dgvImportPreview.Columns.Clear();

            
            dgvImportPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFirstName",
                HeaderText = "First Name",
                DataPropertyName = "FirstName"
            });

            dgvImportPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLastName",
                HeaderText = "Last Name",
                DataPropertyName = "LastName"
            });

            dgvImportPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhone",
                HeaderText = "Phone",
                DataPropertyName = "PhoneNumber"
            });

            dgvImportPreview.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEmail",
                HeaderText = "Email",
                DataPropertyName = "Email"
            });

            
            dgvImportPreview.DataSource = patients;

           
            dgvImportPreview.Visible = true;
            btnConfirmImport.Visible = true;
            btnCancelImport.Visible = true;
            lblImportStatus.Visible = false;
        }

        private void btnConfirmImport_Click(object sender, EventArgs e)
        {
            if (dgvImportPreview.DataSource == null) return;

            List<Patient> patients = (List<Patient>)dgvImportPreview.DataSource;
            int successCount = 0;

            foreach (var patient in patients)
            {
                try
                {
                    _patientService.AddPatient(patient);
                    successCount++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving patient {patient.FullName}: {ex.Message}");
                }
            }

            
            lblImportStatus.Text = $"Successfully imported {successCount} of {patients.Count} patients";
            lblImportStatus.Visible = true;

            
            LoadPatients();

            
            Task.Delay(3000).ContinueWith(t =>
            {
                this.Invoke((MethodInvoker)delegate {
                    dgvImportPreview.Visible = false;
                    btnConfirmImport.Visible = false;
                    btnCancelImport.Visible = false;
                });
            });
        }

        private void btnCancelImport_Click(object sender, EventArgs e)
        {
            dgvImportPreview.DataSource = null;
            dgvImportPreview.Visible = false;
            btnConfirmImport.Visible = false;
            btnCancelImport.Visible = false;
            lblImportStatus.Visible = false;
        }
    }
    }

