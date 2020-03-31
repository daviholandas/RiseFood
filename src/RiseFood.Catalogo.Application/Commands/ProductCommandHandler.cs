using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RiseFood.Catalogo.Domain;
using RiseFood.Core.Messages;

namespace RiseFood.Catalogo.Application.Commands
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper; 

        public ProductCommandHandler(IProductRepository productRepository, 
            IMediator mediator,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mediator = mediator;
            _mapper = mapper;
        }
        
        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (!ValidateCommand(request))
            {
                return true;
            }

            var product = _mapper.Map<Product>(request);
            _productRepository.SaveProduct(product);
            
            
            return false;
        }

        public bool ValidateCommand(Command Request)
        {
            return false;
        }
    }
}