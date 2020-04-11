using System.Threading.Tasks;

namespace RiseFood.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}