﻿namespace ClinicLab.Presentation
{
    partial class LabWorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabWorkerForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureboxInvoices = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxInvoices).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(125, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(198, 185);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 296);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 1;
            label1.Text = "Manage Patients Dashboard";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 18);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 2;
            label2.Text = "Lab Worker Board";
            // 
            // pictureboxInvoices
            // 
            pictureboxInvoices.Image = (Image)resources.GetObject("pictureboxInvoices.Image");
            pictureboxInvoices.Location = new Point(464, 83);
            pictureboxInvoices.Name = "pictureboxInvoices";
            pictureboxInvoices.Size = new Size(202, 184);
            pictureboxInvoices.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxInvoices.TabIndex = 3;
            pictureboxInvoices.TabStop = false;
            pictureboxInvoices.Click += pictureboxInvoices_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 296);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 4;
            label3.Text = "Manage Invoices Dashboard";
            // 
            // LabWorkerForm
            // 
            ClientSize = new Size(831, 493);
            Controls.Add(label3);
            Controls.Add(pictureboxInvoices);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "LabWorkerForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureboxInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // 

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureboxInvoices;
        private Label label3;
    }
}