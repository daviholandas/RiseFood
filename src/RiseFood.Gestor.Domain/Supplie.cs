using System;
using RiseFood.Core.DomainObjects;

namespace RiseFood.Gestor.Domain
{
    public class Supplie : IAggregateRoot
    {
        private Supplie(){}
        public Supplie(int id, string code, string supplieName, decimal? price, string supplieCategoryCode)
        {
            Id = id;
            Code = code;
            SupplieName = supplieName;
            Price = price;
            SupplieCategoryCode = supplieCategoryCode;
        }

        public int Id { get; }
        public string Code { get; }
        public string SupplieName { get; }
        public decimal? Price { get; }
        public SupplieCategory SupplieCategory { get; }

        //EF Relation
        public string SupplieCategoryCode { get; }
    }
}
