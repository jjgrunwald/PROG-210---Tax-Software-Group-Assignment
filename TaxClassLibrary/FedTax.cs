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

            //15% on the portion of taxable income that is $53,359 or less, plus
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
            
            //26% on the portion of taxable income over $106,717 up to $165,430, plus
            if (income >= fedIncome[1] && income <= fedIncome[2])
            {
                totalUntaxed -= totalTaxed;
                tax += totalUntaxed * federalTax[2];
                return income = tax;
            }
            if (income > fedIncome[2])
            {
                tax += federalTax[2] * fedIncome[2];
                totalTaxed += tax;
            }

            //29% on the portion of taxable income over $165,430 up to $235,675, plus
            if (income >= fedIncome[2] && income <= fedIncome[3])
            {
                totalUntaxed -= totalTaxed;
                tax += totalUntaxed * federalTax[3];
                return income = tax;
            }
            if (income > fedIncome[3])
            {
                tax += federalTax[3] * fedIncome[3];
                totalTaxed += tax;
            }

            //33% on the portion of taxable income over $235,675
            if (income >= fedIncome[3] && income <= fedIncome[4])
            {
                totalUntaxed -= totalTaxed;
                tax += totalUntaxed * federalTax[4];
                return income = tax;
            }
            if (income > fedIncome[4])
            {
                tax += federalTax[4] * fedIncome[4];
                totalTaxed += tax;
            }
            return income;
        }

    }
}
