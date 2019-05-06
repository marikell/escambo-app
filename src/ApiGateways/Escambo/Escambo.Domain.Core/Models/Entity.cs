using System;

namespace Escambo.Domain.Core.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        public override bool Equals(object obj)
        {
            var entityToCompare = obj as Entity;

            if (ReferenceEquals(this, entityToCompare)) return true;
            if (entityToCompare is null) return false;

            return Id.Equals(entityToCompare.Id);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"EntityId={Id}";
        }
    }
}
