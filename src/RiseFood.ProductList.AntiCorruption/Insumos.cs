using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace RiseFood.ProductList.AntiCorruption
{
    public class Insumos
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; } 
    }
}