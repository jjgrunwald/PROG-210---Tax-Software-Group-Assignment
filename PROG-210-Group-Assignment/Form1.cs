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

        Image ab = new Bitmap("../../../images/ab.png");
        Image bc = new Bitmap("../../../images/bc.png");
        Image nb = new Bitmap("../../../images/nb.png");
        Image ns = new Bitmap("../../../images/ns.png");
        Image on = new Bitmap("../../../images/on.png");
        Image sk = new Bitmap("../../../images/sk.png");

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
            switch (cmbxProvince.SelectedIndex)
            {
                case 0:
                    picbxCanada.Image = ab;
                    break;
                case 1:
                    picbxCanada.Image = bc;
                    break;
                case 2:
                    picbxCanada.Image = sk;
                    break;
                case 3:
                    picbxCanada.Image = nb;
                    break;
                case 4:
                    picbxCanada.Image = on;
                    break;
                case 5:
                    picbxCanada.Image = ns;
                    break;

            }
        }
    }
}