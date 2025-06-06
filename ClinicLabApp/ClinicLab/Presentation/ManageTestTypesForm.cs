using ClinicLab.Application.BusinessLogic;
using ClinicLab.Application.Models;
using System;
using System.Windows.Forms;


namespace ClinicLab.Presentation
{
    public partial class ManageTestTypesForm : Form
    {
        private readonly TestService service = new();
        private TextBox txtId, txtName, txtPrice;
        private DataGridView testTypesGrid;
        private Button btnAdd, btnUpdate, btnDelete;

        public ManageTestTypesForm()
        {
            InitializeCustomComponent();
        }

        private void InitializeCustomComponent()
        {
            this.Text = "Manage Test Types";
            this.Size = new System.Drawing.Size(600, 400);

            txtId = new TextBox { Left = 20, Top = 20, Width = 100, PlaceholderText = "ID" };
            txtName = new TextBox { Left = 140, Top = 20, Width = 150, PlaceholderText = "Name" };
            txtPrice = new TextBox { Left = 310, Top = 20, Width = 100, PlaceholderText = "Price" };

            btnAdd = new Button { Text = "Add", Left = 20, Top = 60 };
            btnUpdate = new Button { Text = "Update", Left = 100, Top = 60 };
            btnDelete = new Button { Text = "Delete", Left = 180, Top = 60 };

            testTypesGrid = new DataGridView { Left = 20, Top = 100, Width = 540, Height = 200, ReadOnly = true, AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;

            this.Load += ManageTestTypesForm_Load;

            this.Controls.AddRange(new Control[] { txtId, txtName, txtPrice, btnAdd, btnUpdate, btnDelete, testTypesGrid });
        }

        private void LoadTestTypes()
        {
            testTypesGrid.DataSource = null;
            testTypesGrid.DataSource = service.GetAllTestTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var test = new TestType
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text)
            };
            service.AddTestType(test);
            LoadTestTypes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var test = new TestType
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Price = decimal.Parse(txtPrice.Text)
            };
            service.UpdateTestType(test);
            LoadTestTypes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            service.DeleteTestType(id);
            LoadTestTypes();
        }

        private void ManageTestTypesForm_Load(object sender, EventArgs e)
        {
            LoadTestTypes();
        }
    }
}
