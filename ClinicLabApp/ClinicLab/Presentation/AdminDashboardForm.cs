using System;
using System.Windows.Forms;
using ClinicLab.Application.Models;  // Supozoj që tipi User është këtu

namespace ClinicLab.Presentation
{
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentUser;

        public AdminDashboardForm(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Mirësevini, {_currentUser.Username}!";
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm(_currentUser);
            userManagementForm.ShowDialog();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Këtu hapen raportet.");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Këtu hapen cilësimet.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
