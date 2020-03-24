using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RiseFood.Core.Messages;

namespace RiseFood.Catalogo.Application.Commands
{
    public class CategoryCommandHandler : 
        IRequestHandler<CreateCategoryCommand, bool>
    {
        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            if (!ValidCommand(request)) return false;
            return true;
        }

        private bool ValidCommand(Command request)
        {
            return false;
        }
    }
}