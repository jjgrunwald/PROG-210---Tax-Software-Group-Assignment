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

        public decimal provTaxDue;

        public decimal fedTaxDue;

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
            lblSummary.ForeColor = Color.Black;
            lblAnnualIncome.ForeColor = Color.Black;
            lblAnnualIncome2.ForeColor = Color.Black;
            lblFedTaxDue.ForeColor = Color.Black;
            lblFedTaxDue2.ForeColor = Color.Black;
            lblProvTaxDue.ForeColor = Color.Black;
            lblProvTaxDue2.ForeColor = Color.Black;
            lblTotalTaxDue.ForeColor = Color.Black;
            lblTotalTaxDue2.ForeColor = Color.Black;

            income = decimal.Parse(txtbxIncome.Text.ToString());

            decimal incomeFed = income;
            decimal incomeProv = income;
            FedTax tax = new FedTax();

            fedTaxDue = tax.fedTax(incomeFed);

            lblFedTaxDue.Text = "$ " + Decimal.Round(fedTaxDue, 2).ToString();

            ProvTax provTax = new ProvTax();

            switch (province)
            {
                case "ab":
                    provTaxDue = provTax.abTax(incomeProv);
                    Display_Information(fedTaxDue, provTaxDue, income);
                    break;
                case "bc":
                    provTaxDue = provTax.bcTax(incomeProv);
                    Display_Information(fedTaxDue, provTaxDue, income);
                    break;
                case "sk":
                    provTaxDue = provTax.skTax(incomeProv);
                    Display_Information(fedTaxDue, provTaxDue, income);
                    break;
                case "nwt":
                    provTaxDue = provTax.nwtTax(incomeProv);
                    Display_Information(fedTaxDue, provTaxDue, income);
                    break;
                case "on":
                    provTaxDue = provTax.onTax(incomeProv);
                    Display_Information(fedTaxDue, provTaxDue, income);
                    break;
                case "ns":
                    provTaxDue = provTax.nsTax(incomeProv);
                    Display_Information(fedTaxDue, provTaxDue, income);
                    break;
            }

        }

        private void Enable_Inputs()
        {
            txtbxIncome.Enabled = true;
            bttnSubmit.Enabled = true;
            txtbxIncome.Text = "";
        }

        private void Display_Information(decimal fedTaxDue, decimal provTaxDue, decimal income)
        {
            lblProvTaxDue2.Text = "$ " + Decimal.Round(provTaxDue, 2).ToString();
            lblFedTaxDue2.Text = "$ " + Decimal.Round(fedTaxDue, 2).ToString();
            lblAnnualIncome2.Text = "$ " + Decimal.Round(income, 2).ToString();
            decimal totalDue = fedTaxDue+ provTaxDue;
            lblTotalTaxDue2.Text = "$ " + Decimal.Round(totalDue, 2).ToString();
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