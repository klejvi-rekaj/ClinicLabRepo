using ClinicLab.Application.BusinessLogic;
using ClinicLab.Application.Models;
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
    public partial class TestOrderForm : Form
    {
        private readonly TestService service = new();
        private TextBox txtOrderId, txtPatientId, txtTestTypeId;
        private Button btnSubmit;

        public TestOrderForm()
        {
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Order Test";
            this.Size = new System.Drawing.Size(400, 250);

            txtOrderId = new TextBox { Left = 20, Top = 20, Width = 150, PlaceholderText = "Order ID" };
            txtPatientId = new TextBox { Left = 20, Top = 60, Width = 150, PlaceholderText = "Patient ID" };
            txtTestTypeId = new TextBox { Left = 20, Top = 100, Width = 150, PlaceholderText = "Test Type ID" };

            btnSubmit = new Button { Text = "Submit", Left = 20, Top = 140 };
            btnSubmit.Click += btnSubmit_Click;

            this.Controls.AddRange(new Control[] { txtOrderId, txtPatientId, txtTestTypeId, btnSubmit });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var order = new TestOrder
            {
                Id = int.Parse(txtOrderId.Text),
                PatientId = int.Parse(txtPatientId.Text),
                TestTypeId = int.Parse(txtTestTypeId.Text),
                OrderedDate = DateTime.Now,
                Status = "Pending"
            };
            service.AddTestOrder(order);
            MessageBox.Show("Order submitted.");
        }
    }
}
