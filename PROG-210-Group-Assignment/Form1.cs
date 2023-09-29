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
            bttnSubmit.Enabled = false;
            lblProvTaxDue2.Visible = true;
            lblFedTaxDue2.Visible = true;


            income = decimal.Parse(txtbxIncome.Text.ToString());

            decimal incomeFed = income;
            decimal incomeProv = income;

            FedTax tax = new FedTax();

            decimal fedTax = tax.fedTax(incomeFed);

            lblFedTaxDue.Text = "$ " + Decimal.Round(fedTax, 2).ToString();

            ProvTax provTax = new ProvTax();

            switch (province)
            {
                case "ab":
                    lblProvTaxDue.Text = "$ " + Decimal.Round(provTax.abTax(incomeProv), 2).ToString();
                    break;
                case "bc":
                    lblProvTaxDue.Text = "$ " + Decimal.Round(provTax.bcTax(incomeProv), 2).ToString();
                    break;
                case "sk":
                    lblProvTaxDue.Text = "$ " + Decimal.Round(provTax.skTax(incomeProv), 2).ToString();
                    break;
                case "nwt":
                    lblProvTaxDue.Text = "$ " + Decimal.Round(provTax.nwtTax(incomeProv), 2).ToString();
                    break;
                case "on":
                    lblProvTaxDue.Text = "$ " + Decimal.Round(provTax.onTax(incomeProv), 2).ToString();
                    break;
                case "ns":
                    lblProvTaxDue.Text = "$ " + Decimal.Round(provTax.nsTax(incomeProv), 2).ToString();
                    break;

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