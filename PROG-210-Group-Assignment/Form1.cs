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

        public decimal income;

        public string province;

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

            income = decimal.Parse(txtbxIncome.Text.ToString());
            /*            FedTax tax = new FedTax();*/
            /*            decimal fedTax = tax.fedTax(income);*/
            ProvTax provTax = new ProvTax();



            switch (province)
            {
                case "ab":
                    lblProvTaxDue.Text = provTax.abTax(income).ToString();
                    break;
/*                case "bc":
                    provTaxSum = provTax.bcTax(income);
                    break;
                case "sk":
                    provTaxSum = provTax.abTax(income);
                    break;
                case "nb":
                    provTaxSum = provTax.abTax(income);
                    break;
                case "on":
                    provTaxSum = provTax.abTax(income);
                    break;
                case "ns":
                    provTaxSum = provTax.abTax(income);
                    break;
               */
            }
        }

        private void Enable_Inputs()
        {
            txtbxIncome.Enabled = true;
            bttnSubmit.Enabled = true;
            txtbxIncome.Text = "";
        }

        private void cmbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxProvince.SelectedIndex)
            {
                case 0:
                    picbxCanada.Image = ab;
                    province = "ab";
                    Enable_Inputs();
                    break;
                case 1:
                    picbxCanada.Image = bc;
                    province = "bc";
                    Enable_Inputs();
                    break;
                case 2:
                    picbxCanada.Image = sk;
                    province = "sk";
                    Enable_Inputs();
                    break;
                case 3:
                    picbxCanada.Image = nb;
                    province = "nb";
                    Enable_Inputs();
                    break;
                case 4:
                    picbxCanada.Image = on;
                    province = "on";
                    Enable_Inputs();
                    break;
                case 5:
                    picbxCanada.Image = ns;
                    province = "ns";
                    Enable_Inputs();
                    break;

            }
        }
    }
}