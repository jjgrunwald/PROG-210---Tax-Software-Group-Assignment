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
            decimal result = tax.fedTax(2500);
            Assert.AreEqual(375, result);

        }

        [TestMethod]
        public void CalcProv_Tax_2500()
        {
            ProvTax tax = new ProvTax();
            decimal result = tax.abTax(2500);
            Assert.AreEqual(375, result);

        }

        [TestMethod]
        public void CalcFedTax_25000()
        {
            FedTax tax = new FedTax();
            decimal result = tax.fedTax(25000);
            Assert.AreEqual(3750, result);

        }

        [TestMethod]
        public void CalcFedTax_56000()
        {
            FedTax tax = new FedTax();
            decimal result = tax.fedTax(56000);
            Assert.AreEqual(541.405m+8003.85m, result);

        }
    }
}