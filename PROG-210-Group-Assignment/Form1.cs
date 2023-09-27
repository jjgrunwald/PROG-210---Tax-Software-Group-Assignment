using System.Security.Cryptography.X509Certificates;

using TaxClassLibrary;

namespace PROG_210_Group_Assignment
{
    public partial class Form1 : Form
    {

        ProvTax provTax;

        FedTax fedTax;

        public Form1()
        {
            InitializeComponent();
        }

        public decimal income = 0;

        string[] provinceList = { "Alberta",  "British Columbia", "Saskatchewan",
                                    "North West Territories", "Ontario", "Nova Scotia"};

        Image ab = new Bitmap("../images/ab.png");

        private void bttnSubmit_Click(object sender, EventArgs e)
        {
            //Figure out which province is selected, and call the proper method.

            income = decimal.Parse(bttnSubmit.Text);
            FedTax tax = new FedTax();
            decimal fedTax = tax.fedTax(income);
            ProvTax provTax = new ProvTax();
            decimal abTax = provTax.abTax(income);
        }

        private void cmbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}