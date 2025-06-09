using System;
using System.Windows.Forms;
using ClinicLab.Application.Models;
using ClinicLab.Application.BusinessLogic;

namespace ClinicLab.Presentation
{
    public partial class AddEditUserForm : Form
    {
        private readonly UserService _userService;
        private readonly User _currentUser;
        private readonly User _userToEdit;
        private readonly bool _isEditMode;

        public AddEditUserForm(User currentUser, User userToEdit = null)
        {
            InitializeComponent();
            _userService = new UserService();
            _currentUser = currentUser;
            _userToEdit = userToEdit;
            _isEditMode = userToEdit != null;
        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = Enum.GetValues(typeof(UserRole));

            if (_isEditMode)
            {
                txtName.Text = _userToEdit.Username;
                txtEmail.Text = _userToEdit.Email;
                txtPassword.Text = _userToEdit.PasswordHash;
                cmbRole.SelectedItem = _userToEdit.Role;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            UserRole role = (UserRole)cmbRole.SelectedItem;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Të gjitha fushat janë të detyrueshme!", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_isEditMode)
                {
                    _userToEdit.Username = name;
                    _userToEdit.Email = email;
                    _userToEdit.PasswordHash = password;
                    _userToEdit.Role = role;

                    _userService.UpdateUser(_currentUser, _userToEdit);
                }
                else
                {
                    var newUser = new User
                    {
                        Username = name,
                        Email = email,
                        PasswordHash = password,
                        Role = role
                    };

                    _userService.AddUser(_currentUser, newUser);
                }

                MessageBox.Show("Përdoruesi u ruajt me sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Akses i mohuar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë ruajtjes: {ex.Message}", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
