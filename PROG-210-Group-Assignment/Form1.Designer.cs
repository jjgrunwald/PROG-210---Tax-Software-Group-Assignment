namespace PROG_210_Group_Assignment
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
            txtbxIncome = new TextBox();
            bttnSubmit = new Button();
            cmbxProvince = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtbxIncome
            // 
            txtbxIncome.Location = new Point(348, 364);
            txtbxIncome.Name = "txtbxIncome";
            txtbxIncome.Size = new Size(202, 23);
            txtbxIncome.TabIndex = 0;
            // 
            // bttnSubmit
            // 
            bttnSubmit.Location = new Point(556, 364);
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
            cmbxProvince.Location = new Point(178, 364);
            cmbxProvince.Name = "cmbxProvince";
            cmbxProvince.Size = new Size(164, 23);
            cmbxProvince.TabIndex = 2;
            cmbxProvince.SelectedIndexChanged += cmbxProvince_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.canada_map;
            pictureBox1.Location = new Point(241, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 254);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxProvince);
            Controls.Add(bttnSubmit);
            Controls.Add(txtbxIncome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxIncome;
        private Button bttnSubmit;
        private ComboBox cmbxProvince;
        private PictureBox pictureBox1;
    }
}