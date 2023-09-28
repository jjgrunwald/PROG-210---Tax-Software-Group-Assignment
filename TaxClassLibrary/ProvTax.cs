using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TaxClassLibrary
{
    public class ProvTax
    {

        //Alberta Tax

        public void abTax(decimal income)
        {
                                /*            Tax rate    Taxable income threshold
                                10 % on the portion of taxable income that is $142,292 or less, plus
                                12 % on the portion of taxable income over $142,292 up to $170,751, plus
                                13 % on the portion of taxable income over $170,751 up to $227,668, plus
                                14 % on the portion of taxable income over $227,668 up to $341,502, plus
                                15 % on the portion of taxable income over $341,502*/

            decimal[] provincialTax = { 0.10m, 0.12m, 0.13m, 0.14m, 0.15m };
            decimal[] incomeBracket = { 142292m, 170751m, 227668m, 341502m };

            TaxCalculator(income, provincialTax, incomeBracket);
        }

        public void bcTax(decimal income)
        {
                        /*            Tax rate    Taxable income threshold
                        5.06 % on the portion of taxable income that is $45,654 or less, plus
                        7.7 % on the portion of taxable income over $45,654 up to $91,310, plus
                        10.5 % on the portion of taxable income over $91,310 up to $104,835, plus
                        12.29 % on the portion of taxable income over $104,835 up to $127,299, plus
                        14.7 % on the portion of taxable income over $127,299 up to $172,602, plus
                        16.8 % on the portion of taxable income over $172,602 up to $240,716, plus
                        20.5 % on the portion of taxable income over $240,716*/

            decimal[] provincialTax = { 0.0506m, 0.0707m, 0.1005m, 0.1229m, 0.147m, 0.168m, 0.205m };
            decimal[] incomeBracket = { 45654m, 91310m, 104835m, 127299m, 172602m, 240716m};

            TaxCalculator(income, provincialTax, incomeBracket);

        }

        public void skTax(decimal income)
        {
/*                                    Tax rate    Taxable income threshold
                        10.5 % on the portion of taxable income that is $49,720 or less, plus
                        12.5 % on the portion of taxable income over $49,720 up to $142,058, plus
                        14.5 % on the portion of taxable income over $142,058*/

            decimal[] provincialTax = { 0.105m, 0.125m, 0.145m  };
            decimal[] incomeBracket = { 49720m, 142058 };

            TaxCalculator(income, provincialTax, incomeBracket);
        }

        public void nwtTax(decimal income)
        {
                            /*            Tax rate Taxable income threshold
                            5.9 % on the portion of taxable income that is $48,326 or less, plus
                            8.6 % on the portion of taxable income over $48,326 up to $96,655, plus
                            12.2 % on the portion of taxable income over $96,655 up to $157,139, plus
                            14.05 % on the portion of taxable income over $157,139*/


            decimal[] provincialTax = { 0.59m, 0.86m, 0.122m, 0.1405m };
            decimal[] incomeBracket = { 48326m, 96655m, 157139m, 157139m};

            TaxCalculator(income, provincialTax, incomeBracket);
        }

        public void onTax(decimal income)
        {
                                /*            Tax rate    Taxable income threshold
                                5.05 % on the portion of taxable income that is $49,231 or less, plus
                                9.15 % on the portion of taxable income over $49,231 up to $98,463, plus
                                11.16 % on the portion of taxable income over $98,463 up to $150,000, plus
                                12.16 % on the portion of taxable income over $150,000 up to $220,000, plus
                                13.16 % on the portion of taxable income over $220,000*/


            decimal[] provincialTax = { 0.505m, 0.915m, 0.1116m, 0.1216m, 0.1316m };
            decimal[] incomeBracket = { 49231, 98463, 150000, 220000};

            TaxCalculator(income, provincialTax, incomeBracket);
        }

        public void nsTax(decimal income)
        {
                                /*            Tax rate Taxable income threshold
                                8.79 % on the portion of taxable income that is $29,590 or less, plus
                                14.95 % on the portion of taxable income over $29,590 up to $59,180, plus
                                16.67 % on the portion of taxable income over $59,180 up to $93,000, plus
                                17.5 % on the portion of taxable income over $93,000 up to $150,000, plus
                                21 % on the portion of taxable income over $150,000*/


            decimal[] provincialTax = { 0.879m, 0.1495m, 0.1667m, 0.175m, 0.21m };
            decimal[] incomeBracket = { 29590, 59180, 93000, 150000 };

            TaxCalculator(income, provincialTax, incomeBracket);
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
                    tax += totalUntaxed * provincialTax[i] + 1;
                    return tax;
                }
                if (income > incomeBracket[i] + 1)
                {
                    tax += provincialTax[i] + 1 * incomeBracket[i] + 1;
                    totalTaxed += tax;
                }
            }

            decimal finalBracket = incomeBracket.AsQueryable().Last();
            decimal finalTax = provincialTax.AsQueryable().Last();

            if (income > finalBracket)
            {
                tax += totalUntaxed * finalTax;
                totalTaxed += tax;
                return tax;
            }
            else
         return tax;

        }

    }
}
