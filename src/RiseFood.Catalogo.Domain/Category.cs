using System;
using System.Collections.Generic;
using RiseFood.Core.BaseClasses;
using RiseFood.Core.DomainObjects;

namespace RiseFood.Catalogo.Domain
{
    public class Category : Entity
    {
        private Category(){}
        public Category( int code, string name)
        {
            Code = code;
            Name = name;
            
            Validate();
        }
        public int Code {get; private set;}
        public string Name {get; private set;}
        

        public override void Validate()
        {
            Validations.ValidateIfEmpty(Name, "The name of category can't be empty or null.");
            Validations.ValidateIfNull(Code, "The code of category can't be null");
        }

        public override string ToString()
        {
            return $"{Code} - {Name}";
        }
    }
}
