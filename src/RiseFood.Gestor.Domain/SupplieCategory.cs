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

        public string Code { get; private set; }
        public string CategoryName { get; private set; }

        //EF Relation
        public IEnumerable<Supplie> Supplies { get; private set; }

        public override string  ToString()
        {
            return $"{CategoryName}";
        }

    }
}