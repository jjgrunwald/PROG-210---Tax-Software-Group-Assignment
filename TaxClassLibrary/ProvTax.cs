using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TaxClassLibrary
{
    public class ProvTax
    {

        //Alberta Tax

        public decimal abTax(decimal income)
        {
            decimal[] provincialTax = { 0.10m, 0.12m, 0.13m, 0.14m, 0.15m };
            decimal[] incomeBracket = { 142292m, 170751m, 227668m, 341502m };

            decimal tax = 0;

            decimal totalTaxed = 0;

            decimal totalUntaxed = income;

            //10% on the portion of taxable income that is $142,292 or less, plus
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


            //attempting to refactor all of this code below, into the loop above.
            /*
                        decimal[] abTax = { 0.10m, 0.12m, 0.13m, 0.14m, 0.15m };
                        decimal[] abIncome = { 142292m, 170751m, 227668m, 341502m };

                        decimal tax = 0;

                        decimal totalTaxed = 0;

                        decimal totalUntaxed = income;

                        //10% on the portion of taxable income that is $142,292 or less, plus
                        if (income < abIncome[0])
                        {
                            tax = abTax[0] * income;
                            totalTaxed += tax;
                        }
                        if (income > abIncome[0])
                        {
                            tax += abTax[0] * abIncome[0];
                            totalTaxed += tax;
                        }

                        for (int i = 0; i < abIncome.Length; i++)
                        {
                            if (income >= abIncome[i] && income <= abIncome[i]+1)
                            {
                                totalUntaxed -= totalTaxed;
                                tax += totalUntaxed * abTax[i]+1;
                                return income = tax;
                            }
                            if (income > abIncome[i]+1)
                            {
                                tax += abTax[i]+1 * abIncome[i]+1;
                                totalTaxed += tax;
                            }

                        }

                        return income + tax;

                        //12% on the portion of taxable income over $142,292 up to $170,751, plus
                        if (income >= abIncome[0] && income <= abIncome[1])
                        {
                            totalUntaxed -= totalTaxed;
                            tax += totalUntaxed * abTax[1];
                            return income = tax;
                        }
                        if (income > abIncome[1])
                        {
                            tax += abTax[1] * abIncome[1];
                            totalTaxed += tax;
                        }

                        //13% on the portion of taxable income over $170,751 up to $227,668, plus
                        if (income >= abIncome[1] && income <= abIncome[2])
                        {
                            totalUntaxed -= totalTaxed;
                            tax += totalUntaxed * abTax[2];
                            return income = tax ;
                        }
                        if (income > abIncome[2])
                        {
                            tax += abTax[2] * abIncome[2];
                            totalTaxed += tax;
                        }

                        //14% on the portion of taxable income over $227,668 up to $341,502, plus
                        if (income >= abIncome[2] && income <= abIncome[3])
                        {
                            totalUntaxed -= totalTaxed;
                            tax += totalUntaxed * abTax[3];
                            return income = tax;
                        }
                        if (income > abIncome[3])
                        {
                            tax += abTax[3] * abIncome[3];
                            totalTaxed += tax;
                        }

                        //15% on the portion of taxable income over $341,502
                        if (income >= abIncome[3] && income <= abIncome[4])
                        {
                            totalUntaxed -= totalTaxed;
                            tax += totalUntaxed * abTax[4];
                            return income = tax;
                        }
                        if (income > abIncome[3])
                        {
                            tax += abTax[3] * income;
                            totalTaxed += tax;
                        }

                        return income + tax;*/

        }

        public decimal bcTax(decimal income)
        {
            /*            5.06 % on the portion of taxable income that is $45,654 or less, plus
            7.7 % on the portion of taxable income over $45,654 up to $91,310, plus
            10.5 % on the portion of taxable income over $91,310 up to $104,835, plus
            12.29 % on the portion of taxable income over $104,835 up to $127,299, plus
            14.7 % on the portion of taxable income over $127,299 up to $172,602, plus
            16.8 % on the portion of taxable income over $172,602 up to $240,716, plus
            20.5 % on the portion of taxable income over $240,716*/


            decimal[] provincialTax = { 0.0506m, 0.0707m, 0.1005m, 0.1229m, 0.147m, 0.168m, 0.205m };
            decimal[] incomeBracket = { 45654m, 91310m, 104835m, 127299m, 172602m, 240716m};

            decimal tax = 0;

            decimal totalTaxed = 0;

            decimal totalUntaxed = income;

            //10% on the portion of taxable income that is $142,292 or less, plus
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
                    return income = tax;
                }
                if (income > incomeBracket[i] + 1)
                {
                    tax += provincialTax[i] + 1 * incomeBracket[i] + 1;
                    totalTaxed += tax;
                }

            }

            return income + tax;

        }

        public decimal skTax(decimal income)
        {
            return 0;
        }

        public decimal nwtTax(decimal income)
        {
            return 0;
        }

        public decimal onTax(decimal income)
        {
            return 0;
        }

        public decimal nsTax(decimal income)
        {
            return 0;
        }


    }
}
