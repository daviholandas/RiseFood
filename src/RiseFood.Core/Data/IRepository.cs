using System;
using RiseFood.Core.DomainObjects;

namespace RiseFood.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}