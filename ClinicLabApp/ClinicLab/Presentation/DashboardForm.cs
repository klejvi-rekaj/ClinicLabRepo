using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicLab.Application.Models;


namespace ClinicLab.Presentation
{
    public partial class DashboardForm : Form
    {
        private readonly User _loggedInUser;

        public DashboardForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

            lblWelcome.Text = $"Welcome, {_loggedInUser.Username}!";

            if (_loggedInUser.Role != "Admin")
                btnAdminPanel.Enabled = false;
        }
    }
}
