using System.Threading.Tasks;
using RiseFood.Core.Messages;

namespace RiseFood.Core.Mediator
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T occurrence) where T : Event;
    }
}