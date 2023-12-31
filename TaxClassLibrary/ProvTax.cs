using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TaxClassLibrary
{
    public class ProvTax
    {

        //Alberta Tax

        public decimal abTax(decimal income)
        {
            /*            Tax rate    Taxable income threshold
            10 % on the portion of taxable income that is $142,292 or less, plus
            12 % on the portion of taxable income over $142,292 up to $170,751, plus
            13 % on the portion of taxable income over $170,751 up to $227,668, plus
            14 % on the portion of taxable income over $227,668 up to $341,502, plus
            15 % on the portion of taxable income over $341,502*/

            decimal[] provincialTax = { 0.010m, 0.012m, 0.013m, 0.014m, 0.015m };
            decimal[] incomeBracket = { 142292m, 170751m, 227668m, 341502m };

            income = TaxCalculator(income, provincialTax, incomeBracket);

            return income;
        }

        public decimal bcTax(decimal income)
        {
            /*            Tax rate    Taxable income threshold
            5.06 % on the portion of taxable income that is $45,654 or less, plus
            7.7 % on the portion of taxable income over $45,654 up to $91,310, plus
            10.5 % on the portion of taxable income over $91,310 up to $104,835, plus
            12.29 % on the portion of taxable income over $104,835 up to $127,299, plus
            14.7 % on the portion of taxable income over $127,299 up to $172,602, plus
            16.8 % on the portion of taxable income over $172,602 up to $240,716, plus
            20.5 % on the portion of taxable income over $240,716*/

            decimal[] provincialTax = { 0.00506m, 0.00707m, 0.01005m, 0.01229m, 0.0147m, 0.0168m, 0.0205m };
            decimal[] incomeBracket = { 45654m, 91310m, 104835m, 127299m, 172602m, 240716m };

            income = TaxCalculator(income, provincialTax, incomeBracket);

            return income;

        }

        public decimal skTax(decimal income)
        {
            /*                                    Tax rate    Taxable income threshold
                                    10.5 % on the portion of taxable income that is $49,720 or less, plus
                                    12.5 % on the portion of taxable income over $49,720 up to $142,058, plus
                                    14.5 % on the portion of taxable income over $142,058*/

            decimal[] provincialTax = { 0.0105m, 0.0125m, 0.0145m };
            decimal[] incomeBracket = { 49720m, 142058 };

            income = TaxCalculator(income, provincialTax, incomeBracket);

            return income;

        }

        public decimal nwtTax(decimal income)
        {
            /*            Tax rate Taxable income threshold
            5.9 % on the portion of taxable income that is $48,326 or less, plus
            8.6 % on the portion of taxable income over $48,326 up to $96,655, plus
            12.2 % on the portion of taxable income over $96,655 up to $157,139, plus
            14.05 % on the portion of taxable income over $157,139*/


            decimal[] provincialTax = { 0.059m, 0.086m, 0.0122m, 0.01405m };
            decimal[] incomeBracket = { 48326m, 96655m, 157139m, 157139m };

            income = TaxCalculator(income, provincialTax, incomeBracket);

            return income;
        }

        public decimal onTax(decimal income)
        {
            /*            Tax rate    Taxable income threshold
            5.05 % on the portion of taxable income that is $49,231 or less, plus
            9.15 % on the portion of taxable income over $49,231 up to $98,463, plus
            11.16 % on the portion of taxable income over $98,463 up to $150,000, plus
            12.16 % on the portion of taxable income over $150,000 up to $220,000, plus
            13.16 % on the portion of taxable income over $220,000*/


            decimal[] provincialTax = { 0.0505m, 0.0915m, 0.01116m, 0.01216m, 0.01316m };
            decimal[] incomeBracket = { 49231, 98463, 150000, 220000 };

            income = TaxCalculator(income, provincialTax, incomeBracket);

            return income;
        }

        public decimal nsTax(decimal income)
        {
            /*            Tax rate Taxable income threshold
            8.79 % on the portion of taxable income that is $29,590 or less, plus
            14.95 % on the portion of taxable income over $29,590 up to $59,180, plus
            16.67 % on the portion of taxable income over $59,180 up to $93,000, plus
            17.5 % on the portion of taxable income over $93,000 up to $150,000, plus
            21 % on the portion of taxable income over $150,000*/


            decimal[] provincialTax = { 0.0879m, 0.01495m, 0.01667m, 0.0175m, 0.021m };
            decimal[] incomeBracket = { 29590, 59180, 93000, 150000 };

            income = TaxCalculator(income, provincialTax, incomeBracket);

            return income;
        }

        //Tax Calculator Method

        public decimal TaxCalculator(decimal income, decimal[] provincialTax, decimal[] incomeBracket)
        {
            decimal tax = 0;

            decimal totalTaxed = 0;

            decimal totalUntaxed = income;

            if (income < incomeBracket[0])
            {
                tax = provincialTax[0] * income;
                totalTaxed += tax;
            }
            if (income > incomeBracket[0])
            {
                tax += provincialTax[0] * incomeBracket[0];
                totalTaxed += tax;
            }

            for (int i = 0; i < incomeBracket.Length; i++)
            {
                if (income >= incomeBracket[i] && income <= incomeBracket[i] + 1)
                {
                    totalUntaxed -= totalTaxed;
                    tax += totalUntaxed * provincialTax[i]+1;
                    return income = tax;
                }
                if (income > incomeBracket[i]+1)
                {
                    tax += totalUntaxed * provincialTax[i]+1;
                    totalTaxed += tax;
                }
            }

            decimal finalBracket = incomeBracket.AsQueryable().Last();
            decimal finalTax = provincialTax.AsQueryable().Last();

            if (income > finalBracket)
            {
                tax += totalUntaxed * finalTax;
                return income = tax;
            }
            else
                return income = tax;

        }

    }
}
