using System.Threading.Tasks;
using MediatR;
using RiseFood.Core.Messages;

namespace RiseFood.Core.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        private readonly IMediator _mediator;
        
        public async Task PublishEvent<T>(T occurrence) where T : Event
        {
           await _mediator.Publish(occurrence);
        }
    }
}