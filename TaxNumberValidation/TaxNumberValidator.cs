using System;
using System.Linq;

namespace TaxNumberValidation
{
    public static class TaxNumberValidator
    {
        public static bool IsValidTaxNo(long taxNo)
        {
            //Convert long taxNo to an array
            var taxNoArray = taxNo.ToString().Select(q => Convert.ToInt32(q.ToString())).ToArray();

            //modifiedTaxNo is used to calculate sum of the first 9 digits of modified tax number.
            var modifiedTaxNo = new int[9];

            var counter = 1;
            //loop through for first 9 digits.
            for (var i = 0; i < taxNoArray.Length - 1; i++)
            {
                modifiedTaxNo[i] = (taxNoArray[i] + 10 - counter) % 10;
                counter++;
            }

            var sum = 0;
            counter = 1; //set counter to 1.
            for (var i = 0; i < modifiedTaxNo.Length; i++)
            {
                if (modifiedTaxNo[i] == 9)
                {
                    counter++;
                    sum += modifiedTaxNo[i];
                    continue;
                }

                modifiedTaxNo[i] = Convert.ToInt32(modifiedTaxNo[i] * Math.Pow(2, (10 - counter))) % 9;
                counter++;
                sum += modifiedTaxNo[i];
            }

            //result gives us the last digit of tax number.
            var result = (10 - (sum % 10)) % 10;

            //check if the last digit of tax number matches with result
            return result == taxNoArray[^1];
        }
    }
}