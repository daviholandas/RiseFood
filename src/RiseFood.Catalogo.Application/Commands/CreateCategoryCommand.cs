using RiseFood.Catalogo.Application.Validations;
using RiseFood.Core.Messages;

namespace RiseFood.Catalogo.Application.Commands
{
    public class CreateCategoryCommand : Command
    {
        public CreateCategoryCommand(int code, string name)
        {
            Code = code;
            Name = name;
        }
        private  CreateCategoryCommand(){}
        
        public string Name {get; private set;}
        public int Code {get; private set;}

        public override bool IsValid()
        {
            ValidationResult = new CreateCategoryValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}