using System;
using System.Collections.Generic;
using RiseFood.Core.BaseClasses;
using RiseFood.Core.DomainObjects;

namespace RiseFood.Catalogo.Domain
{
    public class Category : Entity
    {
        private Category(){}
        public Category(string name, int code)
        {
            Name = name;
            Code = code;

            Validate();
        }

        public string Name {get; private set;}
        public int Code {get; private set;}

        //EF Relations
        public IEnumerable<Product> Products {get; private set;}

        public override void Validate()
        {
            Validations.ValidateIfEmpty(Name, "The name of category can't be empty or null.");
            Validations.ValidateIfNull(Code, "The code of category can't be null");
        }
    }
}
