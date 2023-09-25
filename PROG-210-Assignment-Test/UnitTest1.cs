using System.Windows.Forms;
using TaxClassLibrary;

namespace PROG_210_Assignment_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcFedTax_2500()
        {
            FedTax tax = new FedTax();
            decimal result = tax.federaltaxcalc(2500);
            Assert.AreEqual(375, result);

        }

        [TestMethod]
        public void CalcFedTax_25000()
        {
            FedTax tax = new FedTax();
            decimal result = tax.federaltaxcalc(25000);
            Assert.AreEqual(3750, result);

        }

        [TestMethod]
        public void CalcFedTax_56000()
        {
            FedTax tax = new FedTax();
            decimal result = tax.federaltaxcalc(56000);
            Assert.AreEqual(541.405m+8003.85m, result);

        }

        internal class ProvTax
        {
            public string province;
            public decimal taxrate;
            public decimal income;

            public void TestMethod1()
            {
                switch (province)
                {
                    case "Newfoundland and Labrador":
                        MessageBox.Show("Hi");
                        if (income <= 41457)
                        {
                            taxrate = 0.087m;
                        }
                        if (income > 41457 && income < 82913)
                        {
                            taxrate = 0.145m;
                        }
                        if (income > 82913 && income < 148027)
                        {
                            taxrate = 0.158m;
                        }
                        if (income > 148027 && income < 207239)
                        {
                            taxrate = 0.178m;
                        }

                        if (income > 207239 && income < 264750)
                        {
                            taxrate = 0.198m;
                        }
                        if (income > 264750 && income < 529500)
                        {
                            taxrate = 0.208m;
                        }
                        if (income > 529500 && income < 1059000)
                        {
                            taxrate = 0.213m;
                        }
                        if (income > 1059000)
                        {
                            taxrate = 0.218m;
                        }
                        break;
                    case "Prince Edward Island":
                        MessageBox.Show("Hi");
                        if (income <= 31984)
                        {
                            taxrate = 0.098m;
                        }
                        if (income > 31984 && income < 63969)
                        {
                            taxrate = 0.138m;
                        }
                        if (income > 63969)
                        {
                            taxrate = 0.167m;
                        }

                        break;
                    case "Nova Scotia":
                        MessageBox.Show("Hi");

                        break;
                    case "New Brunswick":
                        MessageBox.Show("Hi");

                        break;
                    case "Quebec":
                        MessageBox.Show("Hi");

                        break;
                    case "Ontario":
                        MessageBox.Show("Hi");

                        break;
                    case "Manitoba":
                        MessageBox.Show("Hi");

                        break;
                    case "Saskatchewan":
                        MessageBox.Show("Hi");

                        break;
                    case "Alberta":
                        MessageBox.Show("Hi");

                        break;
                    case "British Columbia":
                        MessageBox.Show("Hi");

                        break;
                    case "Yukon":
                        MessageBox.Show("Hi");

                        break;
                    case "Northwest Territories":
                        MessageBox.Show("Hi");

                        break;
                    case "Nunavut":
                        MessageBox.Show("Hi");

                        break;
                }
            }
        }
    }

}
