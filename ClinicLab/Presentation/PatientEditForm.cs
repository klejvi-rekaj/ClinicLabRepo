using ClinicLab.Application.Models;
using System;
using System.Windows.Forms;

namespace ClinicLab.Presentation
{
    public partial class PatientEditForm : Form
    {
        public Patient Patient { get; private set; }

        public PatientEditForm(Patient patient = null)
        {
            InitializeComponent();
            InitializeGenderComboBox();
            Patient = patient ?? new Patient();
            InitializeForm();
        }

        private void InitializeGenderComboBox()
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Other");
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeForm()
        {
            if (Patient.Id > 0)
            {
                Text = "Edit Patient";
                txtFirstName.Text = Patient.FirstName;
                txtLastName.Text = Patient.LastName;
                dtpDateOfBirth.Value = Patient.DateOfBirth;
                cboGender.SelectedItem = Patient.Gender;
                txtPhone.Text = Patient.PhoneNumber;
                txtEmail.Text = Patient.Email;
                txtAddress.Text = Patient.Address;
            }
            else
            {
                Text = "Add New Patient";
                dtpDateOfBirth.Value = DateTime.Now.AddYears(-30);
                cboGender.SelectedIndex = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;


            Patient.FirstName = txtFirstName.Text;
            Patient.LastName = txtLastName.Text;
            Patient.PhoneNumber = txtPhone.Text;
            Patient.Email = txtEmail.Text;
            Patient.Address = txtAddress.Text;
            Patient.DateOfBirth = dtpDateOfBirth.Value;
            Patient.Gender = cboGender.SelectedItem?.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First name is required.");
                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last name is required.");
                txtLastName.Focus();
                return false;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.");
                cboGender.Focus();
                return false;
            }

            return true;
        }

     
    }
}
