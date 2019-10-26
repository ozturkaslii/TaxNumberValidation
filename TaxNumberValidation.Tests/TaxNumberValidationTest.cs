using System;
using TaxNumberValidation;
using Xunit;

namespace TaxNoValidation.Tests
{
    public class TaxNumberValidationTest
    {
        [Fact]
        public void ValidTaxNo()
        {
            const long validTaxNo = 5843324351;
            var isValid = TaxNumberValidator.IsValidTaxNo(validTaxNo);
            Assert.True(isValid);
        }

        [Fact]
        public void InvalidTaxNo()
        {
            const long invalidTaxNo = 1234567891;
            var isValid = TaxNumberValidator.IsValidTaxNo(invalidTaxNo);
            Assert.False(isValid);
        }
    }
}
