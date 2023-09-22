using System.Security.Cryptography.X509Certificates;

namespace PROG_210_Group_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal income = 0;


        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            income = decimal.Parse(bttnSubmit.Text);
        }
    }
}