using SkyTechnicalTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace SkyTechnicalTest.Repository.Tests
{
    public class BillingUnitTest
    {
        [Fact]
        void WhenABillIsRequested_ThenABillShouldBeReturned()
        {
            // Arrange
            var id = 1;
            var expected = new Bill();
            var repository = new BillingRepository();

            // Act
            var actual = repository.Get(id); 

            // Assert
            Assert.NotNull(actual.Statement.Due);
        }

        [Fact]
        void WhenAFileDoesNotExist_ThenAnEmptyObjectShouldBeReturned()
        {
            // Arrange
            var id = 0;
            var expected = new Bill();
            var repository = new BillingRepository();

            // Act
            var actual = repository.Get(id);

            // Assert
            Assert.Null(actual);
        }
    }
}
