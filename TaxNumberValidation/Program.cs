using System;
using TaxNumberValidation;

namespace TaxNoValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //valid and invalid tax numbers
            const long validTaxNo = 5843324351;
            const long invalidTaxNo = 1234567891;

            //returns true
            Console.WriteLine(TaxNumberValidator.IsValidTaxNo(validTaxNo));

            //returns false
            Console.WriteLine(TaxNumberValidator.IsValidTaxNo(invalidTaxNo));
            Console.ReadLine();
        }
    }
}