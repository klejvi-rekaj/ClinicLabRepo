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
    public partial class UploadResultForm : Form
    {
        private readonly TestService service = new();
        private TextBox txtOrderId;
        private Button btnUpload;

        public UploadResultForm()
        {
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Upload Result";
            this.Size = new System.Drawing.Size(400, 180);

            txtOrderId = new TextBox { Left = 20, Top = 20, Width = 150, PlaceholderText = "Order ID" };
            btnUpload = new Button { Text = "Upload PDF", Left = 20, Top = 60 };
            btnUpload.Click += btnUpload_Click;

            this.Controls.AddRange(new Control[] { txtOrderId, btnUpload });
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int orderId = int.Parse(txtOrderId.Text);
                service.UploadResult(orderId, dialog.FileName);
                MessageBox.Show("Result uploaded.");
            }
        }
    }
}
