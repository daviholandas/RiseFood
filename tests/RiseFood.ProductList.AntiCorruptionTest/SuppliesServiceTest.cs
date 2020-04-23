using System.Linq;
using Moq;
using Moq.AutoMock;
using RiseFood.ProductList.AntiCorruption;
using Xunit;

namespace RiseFood.ProductList.AntiCorruptionTest
{
    [Collection(nameof(SuppliesCollection))]
    public class SuppliesServiceTest
    {
        public readonly SuppliesFixture _suppliesFixture;
        
        public SuppliesServiceTest(SuppliesFixture suppliesFixture)
        {
            _suppliesFixture = suppliesFixture;
        }
        
        [Fact(DisplayName = "List all supplies test")]
        public async void SuppliesService_ListSupplies_SuccessListAllSupplies()
        {
            //Arrange
            var service = _suppliesFixture.CreateSuppliesService();
            
            //Act
            var supplies = await service.GetAllSupplies();

            //Assert
            Assert.True(supplies.Any());
        }
    }
}