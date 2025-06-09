using ClinicLab.Application.BusinessLogic;
using ClinicLab.Application.Models;
using System;
using System.Windows.Forms;

namespace ClinicLab.Presentation
{
    public partial class UserManagementForm : Form
    {
        private readonly UserService _userService;
        private readonly User _currentUser;

        public UserManagementForm(User currentUser)
        {
            InitializeComponent();
            _userService = new UserService();
            _currentUser = currentUser;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = _userService.GetAllUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditUserForm(_currentUser);
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.DataBoundItem is User selectedUser)
            {
                var form = new AddEditUserForm(_currentUser, selectedUser);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow?.DataBoundItem is User selectedUser)
            {
                var confirm = MessageBox.Show($"Je i sigurt që do të fshish përdoruesin '{selectedUser.Username}'?",
                                             "Konfirmo fshirjen", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _userService.DeleteUser(_currentUser, selectedUser.Id);
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gabim gjatë fshirjes: " + ex.Message);
                    }
                }
            }
        }
    }
}
