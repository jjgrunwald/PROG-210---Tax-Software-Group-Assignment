using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace TaxClassLibrary
{
    public class ProvTax
    {

        public decimal abTax(decimal income)
        {
            
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
                tax += abTax[3] * abIncome[3];
                totalTaxed += tax;
            }



            return income + tax;

            decimal taxedIncome = +tax;

            //Income greater than $142,292
            if (income >= abIncome[0])
            {
                tax = abTax[0] * abIncome[0];

            }
            
            //Income Between 
            if (income >= 142929)
            {


            }

            return income + tax;
        }

        public decimal bcTax(decimal income)
        {
            return 0;
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
