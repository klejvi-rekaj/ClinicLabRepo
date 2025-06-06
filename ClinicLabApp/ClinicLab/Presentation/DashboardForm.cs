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
    public partial class DashboardForm : Form
    {
        private Button btnManageTests, btnOrderTest, btnUploadResult;

        public DashboardForm()
        {
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Dashboard";
            this.Size = new System.Drawing.Size(400, 200);

            btnManageTests = new Button { Text = "Manage Test Types", Left = 20, Top = 20, Width = 150 };
            btnOrderTest = new Button { Text = "Order Test", Left = 20, Top = 60, Width = 150 };
            btnUploadResult = new Button { Text = "Upload Result", Left = 20, Top = 100, Width = 150 };

            btnManageTests.Click += (s, e) => new ManageTestTypesForm().ShowDialog();
            btnOrderTest.Click += (s, e) => new TestOrderForm().ShowDialog();
            btnUploadResult.Click += (s, e) => new UploadResultForm().ShowDialog();

            this.Controls.AddRange(new Control[] { btnManageTests, btnOrderTest, btnUploadResult });
        }
    }
}

