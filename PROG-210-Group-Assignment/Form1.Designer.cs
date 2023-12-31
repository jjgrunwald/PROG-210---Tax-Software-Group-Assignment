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
            lblIncome = new Label();
            lblSubTitle = new Label();
            lblEditionTitle = new Label();
            lblDollar = new Label();
            lblProvTaxDue2 = new Label();
            lblProvince = new Label();
            lblProvTaxDue = new Label();
            lblFedTaxDue = new Label();
            lblFedTaxDue2 = new Label();
            lblAnnualIncome = new Label();
            lblAnnualIncome2 = new Label();
            lblTotalTaxDue = new Label();
            lblTotalTaxDue2 = new Label();
            lblSummary = new Label();
            ((System.ComponentModel.ISupportInitialize)picbxCanada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtbxIncome
            // 
            txtbxIncome.Enabled = false;
            txtbxIncome.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbxIncome.Location = new Point(303, 541);
            txtbxIncome.Name = "txtbxIncome";
            txtbxIncome.Size = new Size(202, 26);
            txtbxIncome.TabIndex = 0;
            txtbxIncome.Text = "Select Province";
            // 
            // bttnSubmit
            // 
            bttnSubmit.Enabled = false;
            bttnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bttnSubmit.Location = new Point(511, 541);
            bttnSubmit.Name = "bttnSubmit";
            bttnSubmit.Size = new Size(75, 26);
            bttnSubmit.TabIndex = 1;
            bttnSubmit.Text = "Submit";
            bttnSubmit.UseVisualStyleBackColor = true;
            bttnSubmit.Click += bttnSubmit_Click;
            // 
            // cmbxProvince
            // 
            cmbxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxProvince.Items.AddRange(new object[] { "Alberta", "British Columbia", "Saskatchewan", "North West Territories", "Ontario", "Nova Scotia" });
            cmbxProvince.Location = new Point(62, 541);
            cmbxProvince.Name = "cmbxProvince";
            cmbxProvince.Size = new Size(164, 23);
            cmbxProvince.TabIndex = 2;
            cmbxProvince.SelectedIndexChanged += cmbxProvince_SelectedIndexChanged;
            // 
            // picbxCanada
            // 
            picbxCanada.Image = Properties.Resources.canada_map;
            picbxCanada.Location = new Point(120, 176);
            picbxCanada.Name = "picbxCanada";
            picbxCanada.Size = new Size(385, 317);
            picbxCanada.SizeMode = PictureBoxSizeMode.StretchImage;
            picbxCanada.TabIndex = 3;
            picbxCanada.TabStop = false;
            // 
            // picbxLogo
            // 
            picbxLogo.Image = Properties.Resources.tax_logo;
            picbxLogo.Location = new Point(84, 19);
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
            lblTitle.Location = new Point(215, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 86);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Taxes, Eh?";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIncome.Location = new Point(303, 523);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(134, 15);
            lblIncome.TabIndex = 7;
            lblIncome.Text = "Enter your 2023 income:";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTitle.Location = new Point(239, 97);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(273, 32);
            lblSubTitle.TabIndex = 8;
            lblSubTitle.Text = "Canadian Tax Software";
            // 
            // lblEditionTitle
            // 
            lblEditionTitle.AutoSize = true;
            lblEditionTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditionTitle.Location = new Point(352, 129);
            lblEditionTitle.Name = "lblEditionTitle";
            lblEditionTitle.Size = new Size(160, 20);
            lblEditionTitle.TabIndex = 9;
            lblEditionTitle.Text = "2023 Tax Year Edition";
            // 
            // lblDollar
            // 
            lblDollar.AutoSize = true;
            lblDollar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDollar.Location = new Point(278, 532);
            lblDollar.Name = "lblDollar";
            lblDollar.Size = new Size(28, 32);
            lblDollar.TabIndex = 10;
            lblDollar.Text = "$";
            // 
            // lblProvTaxDue2
            // 
            lblProvTaxDue2.AutoSize = true;
            lblProvTaxDue2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProvTaxDue2.Location = new Point(406, 775);
            lblProvTaxDue2.Name = "lblProvTaxDue2";
            lblProvTaxDue2.Size = new Size(0, 18);
            lblProvTaxDue2.TabIndex = 11;
            // 
            // lblProvince
            // 
            lblProvince.AutoSize = true;
            lblProvince.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProvince.Location = new Point(62, 523);
            lblProvince.Name = "lblProvince";
            lblProvince.Size = new Size(117, 15);
            lblProvince.TabIndex = 6;
            lblProvince.Text = "Select your province:";
            // 
            // lblProvTaxDue
            // 
            lblProvTaxDue.AutoSize = true;
            lblProvTaxDue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblProvTaxDue.ForeColor = SystemColors.AppWorkspace;
            lblProvTaxDue.Location = new Point(127, 771);
            lblProvTaxDue.Name = "lblProvTaxDue";
            lblProvTaxDue.Size = new Size(156, 21);
            lblProvTaxDue.TabIndex = 12;
            lblProvTaxDue.Text = "Provincial Tax Due:";
            // 
            // lblFedTaxDue
            // 
            lblFedTaxDue.AutoSize = true;
            lblFedTaxDue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFedTaxDue.ForeColor = SystemColors.AppWorkspace;
            lblFedTaxDue.Location = new Point(127, 710);
            lblFedTaxDue.Name = "lblFedTaxDue";
            lblFedTaxDue.Size = new Size(135, 21);
            lblFedTaxDue.TabIndex = 14;
            lblFedTaxDue.Text = "Federal Tax Due:";
            // 
            // lblFedTaxDue2
            // 
            lblFedTaxDue2.AutoSize = true;
            lblFedTaxDue2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFedTaxDue2.Location = new Point(406, 714);
            lblFedTaxDue2.Name = "lblFedTaxDue2";
            lblFedTaxDue2.Size = new Size(0, 18);
            lblFedTaxDue2.TabIndex = 13;
            // 
            // lblAnnualIncome
            // 
            lblAnnualIncome.AutoSize = true;
            lblAnnualIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnualIncome.ForeColor = SystemColors.AppWorkspace;
            lblAnnualIncome.Location = new Point(127, 649);
            lblAnnualIncome.Name = "lblAnnualIncome";
            lblAnnualIncome.Size = new Size(170, 21);
            lblAnnualIncome.TabIndex = 18;
            lblAnnualIncome.Text = "2023 Annual Income:";
            // 
            // lblAnnualIncome2
            // 
            lblAnnualIncome2.AutoSize = true;
            lblAnnualIncome2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAnnualIncome2.Location = new Point(406, 653);
            lblAnnualIncome2.Name = "lblAnnualIncome2";
            lblAnnualIncome2.Size = new Size(0, 18);
            lblAnnualIncome2.TabIndex = 17;
            // 
            // lblTotalTaxDue
            // 
            lblTotalTaxDue.AutoSize = true;
            lblTotalTaxDue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTaxDue.ForeColor = SystemColors.AppWorkspace;
            lblTotalTaxDue.Location = new Point(127, 832);
            lblTotalTaxDue.Name = "lblTotalTaxDue";
            lblTotalTaxDue.Size = new Size(133, 21);
            lblTotalTaxDue.TabIndex = 16;
            lblTotalTaxDue.Text = "Total Taxes Due:";
            // 
            // lblTotalTaxDue2
            // 
            lblTotalTaxDue2.AutoSize = true;
            lblTotalTaxDue2.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalTaxDue2.Location = new Point(406, 836);
            lblTotalTaxDue2.Name = "lblTotalTaxDue2";
            lblTotalTaxDue2.Size = new Size(0, 18);
            lblTotalTaxDue2.TabIndex = 15;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblSummary.ForeColor = SystemColors.AppWorkspace;
            lblSummary.Location = new Point(224, 584);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(172, 45);
            lblSummary.TabIndex = 19;
            lblSummary.Text = "Summary:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 896);
            Controls.Add(lblSummary);
            Controls.Add(lblAnnualIncome);
            Controls.Add(lblAnnualIncome2);
            Controls.Add(lblTotalTaxDue);
            Controls.Add(lblTotalTaxDue2);
            Controls.Add(lblFedTaxDue);
            Controls.Add(lblFedTaxDue2);
            Controls.Add(lblProvTaxDue);
            Controls.Add(lblProvTaxDue2);
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
            Controls.Add(lblDollar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
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
        private Label lblIncome;
        private Label lblSubTitle;
        private Label lblEditionTitle;
        private Label lblDollar;
        private Label lblProvTaxDue2;
        private Label lblProvince;
        private Label lblProvTaxDue;
        private Label lblFedTaxDue;
        private Label lblFedTaxDue2;
        private Label lblAnnualIncome;
        private Label lblAnnualIncome2;
        private Label lblTotalTaxDue;
        private Label lblTotalTaxDue2;
        private Label lblSummary;
    }
}