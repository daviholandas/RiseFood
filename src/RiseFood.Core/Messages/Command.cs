using System;
using FluentValidation.Results;
using MediatR;

namespace RiseFood.Core.Messages
{
    public abstract class Command : Message, IRequest<bool>
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }
        public DateTime TimeStamp { get; protected set; }
        public ValidationResult ValidationResult { get; protected set; }

        public virtual bool IsValid() => throw new NotImplementedException();
    }
}