using ClinicLab.Application.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicLab.Presentation
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;

        // Add declarations for txtUsername and txtPassword
        private TextBox txtUsername;
        private TextBox txtPassword;

        public LoginForm(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;

            // Initialize txtUsername and txtPassword
            txtUsername = new TextBox
            {
                Location = new Point(10, 10), // Example position
                Size = new Size(200, 20)     // Example size
            };
            txtPassword = new TextBox
            {
                Location = new Point(10, 40), // Example position
                Size = new Size(200, 20),     // Example size,
                PasswordChar = '*'           // Mask input for password
            };

            // Add the TextBox controls to the form
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _authService.Login(txtUsername.Text, txtPassword.Text);
            if (user != null)
            {
                var dashboard = new DashboardForm(user);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login.");
            }
        }
    }
}
