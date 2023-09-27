using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxClassLibrary
{
    public class FedTax
    {
        public decimal fedTax(decimal income)
        {
            decimal[] federalTax = { 0.15m, 0.205m, 0.26m, 0.29m, 0.33m };
            decimal[] fedIncome = { 53359m, 106717m, 165430m, 235675m };

            decimal tax = 0;

            decimal totalTaxed = 0;

            decimal totalUntaxed = income;

            //15%	on the portion of taxable income that is $53,359 or less, plus
            if (income < fedIncome[0])
            {
                tax = federalTax[0] * income;
                totalTaxed += tax;
            }
            if (income > fedIncome[0])
            {
                tax += federalTax[0] * fedIncome[0];
                totalTaxed += tax;

            }

            //20.5% on the portion of taxable income over $53,359 up to $106,717, plus
            if (income >= fedIncome[0] && income <= fedIncome[1])
            {
                totalUntaxed -= totalTaxed;
                tax += totalUntaxed * federalTax[1];
                return income = tax;
            }
            if (income > fedIncome[1])
            {
                tax += federalTax[1] * fedIncome[1];
                totalTaxed += tax;
            }

            return income;
        }

    }
}
