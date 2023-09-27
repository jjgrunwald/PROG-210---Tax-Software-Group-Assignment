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
                        if (income <= 29590)
                        {
                            taxrate = 0.879m;
                        }
                        if (income > 29590 && income < 59180)
                        {
                            taxrate = 0.1495m;
                        }
                        if (income > 59180 && income < 93000)
                        {
                            taxrate = 0.1667m;
                        }
                        if (income > 93000 && income < 150000)
                        {
                            taxrate = 0.175m;
                        }
                        if (income > 150000)
                        {
                            taxrate = 0.21m;
                        }
                        break;
                    case "New Brunswick":
                        MessageBox.Show("Hi");
                        if (income <= 47715)
                        {
                            taxrate = 0.094m;
                        }
                        if (income > 47715 && income < 95431)
                        {
                            taxrate = 0.14m;
                        }
                        if (income > 95431 && income < 176756)
                        {
                            taxrate = 0.16m;
                        }
                        if (income > 176756)
                        {
                            taxrate = 0.195m;
                        }
                        break;
                    case "Quebec":
                        MessageBox.Show("Hi");
                        if (income <= 49275)
                        {
                            taxrate = 0.14m;
                        }
                        if (income > 49275 && income < 98540)
                        {
                            taxrate = 0.19m;
                        }
                        if (income > 98540 && income < 119910)
                        {
                            taxrate = 0.24m;
                        }
                        if (income > 176756)
                        {
                            taxrate = 0.2575m;
                        }
                        break;
                    case "Ontario":
                        MessageBox.Show("Hi");
                        if (income <= 49231)
                        {
                            taxrate = 0.0505m;
                        }
                        if (income > 49231 && income < 98463)
                        {
                            taxrate = 0.0915m;
                        }
                        if (income > 98463 && income < 150000)
                        {
                            taxrate = 0.1116m;
                        }
                        if (income > 150000 && income < 220000)
                        {
                            taxrate = 0.1216m;
                        }
                        if (income > 220000)
                        {
                            taxrate = 0.1316m;
                        }
                        break;
                    case "Manitoba":
                        MessageBox.Show("Hi");
                        if (income <= 36842)
                        {
                            taxrate = 0.108m;
                        }
                        if (income > 36842 && income < 79625)
                        {
                            taxrate = 0.1275m;
                        }
                        if (income > 79625)
                        {
                            taxrate = 0.174m;
                        }
                        break;
                    case "Saskatchewan":
                        MessageBox.Show("Hi");
                        if (income <= 49720)
                        {
                            taxrate = 0.105m;
                        }
                        if (income > 49720 && income < 142058)
                        {
                            taxrate = 0.125m;
                        }
                        if (income > 142058)
                        {
                            taxrate = 0.145m;
                        }
                        break;
                    case "Alberta":
                        MessageBox.Show("Hi");
                        if (income <= 142292)
                        {
                            taxrate = 0.10m;
                        }
                        if (income > 142292 && income < 170751)
                        {
                            taxrate = 0.12m;
                        }
                        if (income > 170751 && income < 227668)
                        {
                            taxrate = 0.13m;
                        }
                        if (income > 227668 && income < 341502)
                        {
                            taxrate = 0.14m;
                        }
                        if (income > 341502)
                        {
                            taxrate = 0.15m;
                        }
                        break;
                    case "British Columbia":
                        MessageBox.Show("Hi");
                        if (income <= 45654)
                        {
                            taxrate = 0.0506m;
                        }
                        if (income > 45654 && income < 91310)
                        {
                            taxrate = 0.077m;
                        }
                        if (income > 91310 && income < 104835)
                        {
                            taxrate = 0.105m;
                        }
                        if (income > 104835 && income < 127299)
                        {
                            taxrate = 0.1229m;
                        }
                        if (income > 127299 && income < 172602)
                        {
                            taxrate = 0.147m;
                        }
                        if (income > 172602 && income < 240716)
                        {
                            taxrate = 0.168m;
                        }
                        if (income > 240716)
                        {
                            taxrate = 0.205m;
                        }
                        break;
                    case "Yukon":
                        MessageBox.Show("Hi");
                        if (income <= 53359)
                        {
                            taxrate = 0.064m;
                        }
                        if (income > 53359 && income < 106717)
                        {
                            taxrate = 0.9m;
                        }
                        if (income > 106717 && income < 165430)
                        {
                            taxrate = 0.109m;
                        }
                        if (income > 165430 && income < 500000)
                        {
                            taxrate = 0.128m;
                        }
                        if (income > 500000)
                        {
                            taxrate = 0.15m;
                        }
                        break;
                    case "Northwest Territories":
                        MessageBox.Show("Hi");
                        if (income <= 48326)
                        {
                            taxrate = 0.059m;
                        }
                        if (income > 48326 && income < 96655)
                        {
                            taxrate = 0.086m;
                        }
                        if (income > 96655 && income < 157139)
                        {
                            taxrate = 0.122m;
                        }
                        if (income > 157139)
                        {
                            taxrate = 0.1405m;
                        }
                        break;
                    case "Nunavut":
                        MessageBox.Show("Hi");
                        if (income <= 50877)
                        {
                            taxrate = 0.04m;
                        }
                        if (income > 50877 && income < 101754)
                        {
                            taxrate = 0.122m;
                        }
                        if (income > 101754 && income < 165429)
                        {
                            taxrate = 0.122m;
                        }
                        if (income > 165429)
                        {
                            taxrate = 0.115m;
                        }
                        break;
                }

                //if (income <= 49275)
                //{
                //    taxrate = 0.14m;
                //}
                //if (income > 49275 && income < 98540)
                //{
                //    taxrate = 0.19m;
                //}
                //if (income > 98540 && income < 119910)
                //{
                //    taxrate = 0.24m;
                //}
                //if (income > 176756)
                //{
                //    taxrate = 0.2575m;
                //}

            }
        }
    }

}
