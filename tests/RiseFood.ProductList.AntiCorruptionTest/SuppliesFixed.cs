using System;
using System.Collections.Generic;
using AutoMapper;
using Bogus;
using Moq.AutoMock;
using RiseFood.ProductList.AntiCorruption;
using Xunit;

namespace RiseFood.ProductList.AntiCorruptionTest
{
    [CollectionDefinition((nameof(SuppliesCollection)))]
    public class SuppliesCollection : ICollectionFixture<SuppliesFixture> {}
    public class SuppliesFixture : IDisposable
    {
        public ISuppliesService SuppliesService;
        public SuppliesServiceFacade SuppliesServiceFacade;
        public AutoMocker Mocker;

        public IEnumerable<Supply> GenerateSupplies(int quantity)
        {
            var supply = new Faker<Supply>("pt_BR")
                .RuleFor(s => s.Id, f => Guid.NewGuid())
                .RuleFor(s => s.Code, f => f.Random.Int(5, 10).ToString())
                .RuleFor(s => s.Name, f => f.Commerce.ProductName())
                .RuleFor(s => s.Price, f => f.Random.Decimal())
                .RuleFor(s => s.Category, f => f.Commerce.Department());

            return supply.Generate(quantity);
            
        }
        
        
        public ISuppliesService CreateSuppliesService()
        {
            SuppliesService = new SuppliesService(
                "mongodb+srv://dev:windows85@cluster0-cyux5.mongodb.net/test?retryWrites=true&w=majority", 
                "12178298172871");
            return SuppliesService;
        }

        public SuppliesServiceFacade CreateSuppliesServiceFacade()
        {
            Mocker = new AutoMocker();
            SuppliesServiceFacade = Mocker.CreateInstance<SuppliesServiceFacade>();
            return SuppliesServiceFacade;
        }

        public void Dispose()
        {
            
        }
    }
}