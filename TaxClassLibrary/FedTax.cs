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
            decimal[] federalTax = { 0.015m, 0.0205m, 0.026m, 0.029m, 0.033m };
            decimal[] incomeBracket = { 53359m, 106717m, 165430m, 235675m };

            decimal tax = 0;

            decimal totalTaxed = 0;

            decimal totalUntaxed = income;

            if (income < incomeBracket[0])
            {
                tax = federalTax[0] * income;
                totalTaxed += tax;
            }
            if (income > incomeBracket[0])
            {
                tax += federalTax[0] * incomeBracket[0];
                totalTaxed += tax;
            }

            for (int i = 0; i < incomeBracket.Length; i++)
            {
                if (income >= incomeBracket[i] && income <= incomeBracket[i] + 1)
                {
                    totalUntaxed -= totalTaxed;
                    tax += totalUntaxed * federalTax[i] + 1;
                    return income = tax;
                }
                if (income > incomeBracket[i] + 1)
                {
                    tax += totalUntaxed * federalTax[i] + 1;
                    totalTaxed += tax;
                }
            }

            decimal finalBracket = incomeBracket.AsQueryable().Last();
            decimal finalTax = federalTax.AsQueryable().Last();

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