using System.Collections.Generic;
using AutoMapper;
using Moq;
using RiseFood.ProductList.AntiCorruption;
using RiseFood.ProductList.Domain;
using Xunit;

namespace RiseFood.ProductList.AntiCorruptionTest
{
    [Collection(nameof(SuppliesCollection))]
    public class SuppliesServiceFacadeTest
    {
        public readonly SuppliesFixture _suppliesFixture;
        private readonly SuppliesServiceFacade _suppliesServiceFacade;

        public SuppliesServiceFacadeTest(SuppliesFixture suppliesFixture)
        {
            _suppliesFixture = suppliesFixture;
            _suppliesServiceFacade = _suppliesFixture.CreateSuppliesServiceFacade();
        }
        
        [Fact(DisplayName = "List all supplies service facade")]
        public void SuppliesServiceFacade_ListSupplies_SuccessListAllSupplies()
        {
            //Arrange
            var suppl = _suppliesFixture.Mocker.GetMock<ISuppliesService>().Setup(s => s.GetAllSupplies())
                .ReturnsAsync( _suppliesFixture.GenerateSupplies(50));
           
            //Act
            var supplies = _suppliesServiceFacade.ListInputProducts();
            //Assert
            _suppliesFixture.Mocker.GetMock<ISuppliesService>().Verify(s =>s.GetAllSupplies(), Times.Once);
            

        }
    }
}