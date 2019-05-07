using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace User.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<Domain.Entities.User> GetAll();
        void Add(Domain.Entities.User user);
        void Remove(Guid id);
        Domain.Entities.User GetById(Guid id);
        void Update(Domain.Entities.User user);
        IEnumerable<Domain.Entities.User> Get(Expression<Func<Domain.Entities.User, bool>> predicate);
        Domain.Entities.User FirstOrDefault(Expression<Func<Domain.Entities.User, bool>> predicate);
    }
}
