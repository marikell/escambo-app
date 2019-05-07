using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Barter.Application.Interfaces
{
    public interface IBarterService
    {
        IEnumerable<Domain.Entities.Barter> GetAll();
        void Add(Domain.Entities.Barter barter);
        void Remove(Guid id);
        Domain.Entities.Barter GetById(Guid id);
        void Update(Domain.Entities.Barter barter);
        IEnumerable<Domain.Entities.Barter> Get(Expression<Func<Domain.Entities.Barter, bool>> predicate);
        Domain.Entities.Barter FirstOrDefault(Expression<Func<Domain.Entities.Barter, bool>> predicate);
    }
}
