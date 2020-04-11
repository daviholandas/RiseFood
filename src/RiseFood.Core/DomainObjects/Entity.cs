using System;

namespace RiseFood.Core.DomainObjects
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }
        
        public static  bool operator !=(Entity a, Entity b) => !( a == b);

        public override int GetHashCode() => (GetType().GetHashCode() * 890) + GetHashCode();

        public override string ToString() => $"{GetType().Name} - Id {Id}";

        public abstract void Validate();

    }
}