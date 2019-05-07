using System;
using System.Linq;
using System.Linq.Expressions;

namespace User.Domain.Interfaces
{
    public interface IUserRepository
    {

        IQueryable<Entities.User> GetAll();
        void Add(Entities.User obj);
        void Remove(Guid id);
        Entities.User GetById(Guid id);
        void Update(Entities.User obj);
        IQueryable<Domain.Entities.User> Get(Expression<Func<Domain.Entities.User, bool>> predicate);        
        Domain.Entities.User FirstOrDefault(Expression<Func<Domain.Entities.User, bool>> predicate);  
        int SaveChanges();
    }
}