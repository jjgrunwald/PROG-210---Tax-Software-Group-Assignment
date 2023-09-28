﻿namespace PROG_210_Group_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtbxIncome = new TextBox();
            bttnSubmit = new Button();
            cmbxProvince = new ComboBox();
            picbxCanada = new PictureBox();
            picbxLogo = new PictureBox();
            lblTitle = new Label();
            lblProvince = new Label();
            lblIncome = new Label();
            lblSubTitle = new Label();
            lblEditionTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)picbxCanada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtbxIncome
            // 
            txtbxIncome.Location = new Point(353, 560);
            txtbxIncome.Name = "txtbxIncome";
            txtbxIncome.Size = new Size(202, 23);
            txtbxIncome.TabIndex = 0;
            // 
            // bttnSubmit
            // 
            bttnSubmit.Location = new Point(561, 560);
            bttnSubmit.Name = "bttnSubmit";
            bttnSubmit.Size = new Size(75, 23);
            bttnSubmit.TabIndex = 1;
            bttnSubmit.Text = "Submit";
            bttnSubmit.UseVisualStyleBackColor = true;
            bttnSubmit.Click += bttnSubmit_Click;
            // 
            // cmbxProvince
            // 
            cmbxProvince.FormattingEnabled = true;
            cmbxProvince.Items.AddRange(new object[] { "Alberta", "British Columbia", "Saskatchewan", "North West Territories", "Ontario", "Nova Scotia" });
            cmbxProvince.Location = new Point(183, 560);
            cmbxProvince.Name = "cmbxProvince";
            cmbxProvince.Size = new Size(164, 23);
            cmbxProvince.TabIndex = 2;
            cmbxProvince.SelectedIndexChanged += cmbxProvince_SelectedIndexChanged;
            // 
            // picbxCanada
            // 
            picbxCanada.Image = Properties.Resources.canada_map;
            picbxCanada.Location = new Point(215, 181);
            picbxCanada.Name = "picbxCanada";
            picbxCanada.Size = new Size(385, 317);
            picbxCanada.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxCanada.TabIndex = 3;
            picbxCanada.TabStop = false;
            // 
            // picbxLogo
            // 
            picbxLogo.Image = Properties.Resources.tax_logo;
            picbxLogo.Location = new Point(172, 26);
            picbxLogo.Name = "picbxLogo";
            picbxLogo.Size = new Size(120, 120);
            picbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxLogo.TabIndex = 4;
            picbxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(303, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 86);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Taxes, Eh?";
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProvince.Location = new Point(183, 542);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(117, 15);
            lblProvince.TabIndex = 6;
            lblProvince.Text = "Select your province:";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncome.Location = new Point(353, 542);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(134, 15);
            lblIncome.TabIndex = 7;
            lblIncome.Text = "Enter your 2023 income:";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTitle.Location = new Point(327, 104);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(273, 32);
            lblSubTitle.TabIndex = 8;
            lblSubTitle.Text = "Canadian Tax Software";
            // 
            // lblEditionTitle
            // 
            lblEditionTitle.AutoSize = true;
            lblEditionTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditionTitle.Location = new Point(440, 136);
            lblEditionTitle.Name = "lblEditionTitle";
            lblEditionTitle.Size = new Size(160, 20);
            lblEditionTitle.TabIndex = 9;
            lblEditionTitle.Text = "2023 Tax Year Edition";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 671);
            Controls.Add(lblEditionTitle);
            Controls.Add(lblIncome);
            Controls.Add(lblProvince);
            Controls.Add(lblTitle);
            Controls.Add(picbxLogo);
            Controls.Add(picbxCanada);
            Controls.Add(cmbxProvince);
            Controls.Add(bttnSubmit);
            Controls.Add(txtbxIncome);
            Controls.Add(lblSubTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Taxes, Eh? - 2023 Edition";
            ((System.ComponentModel.ISupportInitialize)picbxCanada).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxIncome;
        private Button bttnSubmit;
        private ComboBox cmbxProvince;
        private PictureBox picbxCanada;
        private PictureBox picbxLogo;
        private Label lblTitle;
        private Label lblProvince;
        private Label lblIncome;
        private Label lblSubTitle;
        private Label lblEditionTitle;
    }
}