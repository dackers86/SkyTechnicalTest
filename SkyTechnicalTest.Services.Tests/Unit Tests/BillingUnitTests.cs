using Xunit;
using NSubstitute;
using SkyTechnicalTest.Repository;
using SkyTechnicalTest.Domain;

namespace SkyTechnicalTest.Services.Tests
{
    public class BillingUnitTests
    {
        [Fact]
        public void WhenABillIsRequested_ThenABillShouldBeReturned()
        {
            // Arrange
            var id = 1;

            var _billingRepository = Substitute.For<IBillingRepository>();
            _billingRepository.Get(id)
                              .Returns(new Bill());

            var _billingService = new BillingService(_billingRepository);

            // Act
            var actual = _billingService.Get(id);

            //Assert
            Assert.NotNull(actual);
        }
    }
}
