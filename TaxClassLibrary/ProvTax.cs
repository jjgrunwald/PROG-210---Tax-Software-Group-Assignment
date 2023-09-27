namespace TaxClassLibrary
{
    //I am going to write some comments with all of this code, so that way my team mates
    //can review and better understand what is going on.        --J.J.

    public class ProvTax
    {
        public decimal abTax(decimal income)
        {

            //Here I am going to declare a variable called "tax", this variable is going
            //to be used as a running tally of the applicable tax. Since we've already
            //decide that our variable name is going to be "income" I'm going to simply
            //add this to the "income" at the end of the method.
            decimal tax = 0;

            //I am also going to make this variable called "totalTaxed" and what I'm
            //going to do with this, is use it as a way to see how much income I have
            //already applied tax to. This way I do not overtax on previous brackets.
            decimal totalTaxed = 0;

            //Here I am declaring an array of decimals. This is easier than typing them
            //out as seperate variables. This array will be refered to as "abTax" and
            //I will input each of the tax rates for each province inside of their
            //respective methods and arrays.
            decimal[] abTax = { 0.10m, 0.12m, 0.13m, 0.14m, 0.15m };

            //I am going to move the amount that I have for income into the amount for
            //"totalTaxed", I'm going to want to keep these seperate as I'm going to
            //subtract amounts from the "totalTaxed" variable.
            decimal totalUntaxed = income;

            //This is going to represent the tax bracket that is the lowest,
            //which in Alberta is anything less than $142,292. This will be
            //tax 0 in our array, as it is the first, so that is what I'm going
            //to apply and then add the total to the "taxed income" variable"

            decimal taxedIncome = abTax[0] * income;
            

            tax += taxedIncome;

            //Income greater than $142,292
            if (income >= 142929)
            {
                //Since I'm not wanting to re-apply tax to income that's already been taxed,
                //I'm going to subtract the "taxedIncome" from the "totalTaxed" and I'm going
                //to continue to do this in each of the following 'if' statmenets.
                totalUntaxed =-taxedIncome;

            }

            /*            if (totalUntaxed )

                        //Income greater than $341,502
                        if (income => 341502m)
                        {

                        }*/


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
