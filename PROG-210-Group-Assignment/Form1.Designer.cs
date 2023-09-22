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
            SuspendLayout();
            // 
            // txtbxIncome
            // 
            txtbxIncome.Location = new Point(240, 170);
            txtbxIncome.Name = "txtbxIncome";
            txtbxIncome.Size = new Size(202, 23);
            txtbxIncome.TabIndex = 0;
            // 
            // bttnSubmit
            // 
            bttnSubmit.Location = new Point(478, 169);
            bttnSubmit.Name = "bttnSubmit";
            bttnSubmit.Size = new Size(75, 23);
            bttnSubmit.TabIndex = 1;
            bttnSubmit.Text = "Submit";
            bttnSubmit.UseVisualStyleBackColor = true;
            bttnSubmit.Click += bttnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bttnSubmit);
            Controls.Add(txtbxIncome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbxIncome;
        private Button bttnSubmit;
    }
}