using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using RiseFood.Catalogo.Domain;
using RiseFood.Core.Communication.Mediator;
using RiseFood.Core.Messages;
using RiseFood.Core.Messages.CommonMessages.Notifications;

namespace RiseFood.Catalogo.Application.Commands
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, bool>, 
        IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly IMapper _mapper; 

        public ProductCommandHandler(IProductRepository productRepository,
            IMediatorHandler mediatorHandler,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mediatorHandler = mediatorHandler;
            _mapper = mapper;
        }
        
        public async Task<bool> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            if (!ValidateCommand(request)) return false;
            
            var product = _mapper.Map<Product>(request);
            _productRepository.SaveProduct(product);
            
            
            return await _productRepository.UnitOfWork.Commit();
        }

        public async Task<bool> Handle(CreateCategoryCommand request,CancellationToken cancellationToken)
        {
            if (!ValidateCommand(request)) return false;

            var category = _mapper.Map<Category>(request);

            _productRepository.SaveCategory(category);

            return await _productRepository.UnitOfWork.Commit();
        }

      
        public bool ValidateCommand(Command request)
        {
            if (request.IsValid()) return true;

            foreach(var erro in request.ValidationResult.Errors)
            {
                _mediatorHandler.PublishDomainNotification(new DomainNotification(request.MessageType, erro.ErrorMessage));
            }

            return false;
        }
       
    }
}