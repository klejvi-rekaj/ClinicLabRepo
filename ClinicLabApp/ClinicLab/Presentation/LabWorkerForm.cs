﻿using System;
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
    public partial class LabWorkerForm : Form
    {
        public LabWorkerForm()
        {
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (var patientForm = new PatientForm())
            {
                patientForm.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
    }

}
