using System.Threading.Tasks;
using MediatR;
using RiseFood.Core.Messages;
using RiseFood.Core.Messages.CommonMessages.Notifications;

namespace RiseFood.Core.Communication.Mediator
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

        public async Task SendCommand<T>(T command) where T : Command
        {
            await _mediator.Send(command);
        }

        public async Task PublishDomainNotification<T>(T notification) where T : DomainNotification
        {
            await _mediator.Publish(notification);
        }
    }
}