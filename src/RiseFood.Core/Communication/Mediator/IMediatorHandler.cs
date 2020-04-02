using System.Threading.Tasks;
using RiseFood.Core.Messages;
using RiseFood.Core.Messages.CommonMessages.Notifications;

namespace RiseFood.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T occurrence) where T : Event;
        Task SendCommand<T>(T command) where T : Command;
        Task PublishDomainNotification<T>(T notification) where T : DomainNotification; 
    }
}