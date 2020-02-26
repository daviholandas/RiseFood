using System.Collections.Generic;

namespace RiseFood.Gestor.Domain
{
    public class SupplieCategory
    {
        private SupplieCategory(){}
        public SupplieCategory(string code, string categoryName)
        {
            Code = code;
            CategoryName = categoryName;
        }

        public string Code { get; }
        public string CategoryName { get; }

        //EF Relation
        public IEnumerable<Supplie> Supplies {get; }

        public override string  ToString()
        {
            return $"{CategoryName}";
        }

    }
}