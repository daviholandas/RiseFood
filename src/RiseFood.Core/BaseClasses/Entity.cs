using System;

namespace RiseFood.Core.BaseClasses
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id {get; private set;}

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if(ReferenceEquals(this, obj)) return true;
            if(ReferenceEquals(obj, null)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if(ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if(ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 910) + GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} - ID {Id}";
        }

        public abstract void Validate();
    }
}
