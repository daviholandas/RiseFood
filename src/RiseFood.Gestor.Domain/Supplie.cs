using System;
using RiseFood.Core.DomainObjects;

namespace RiseFood.Gestor.Domain
{
    public class Supplie : IAggregateRoot
    {
        private Supplie(){}
        public Supplie(int id, string code, string supplieName, decimal? price)
        {
            Id = id;
            Code = code;
            SupplieName = supplieName;
            Price = price;
        }

        public int Id { get; private set; }
        public string Code { get; private set; }
        public string SupplieName { get; private set; }
        public decimal? Price { get; private set; }
        public SupplieCategory SupplieCategory { get; private set; }

        //EF Relation
        public string SupplieCategoryCode { get; private set; }
    }
}
