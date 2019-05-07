using System;
using System.Linq;
using System.Linq.Expressions;

namespace Barter.Domain.Interfaces
{
    public interface IBarterRepository
    {
        IQueryable<Entities.Barter> GetAll();
        void Add(Entities.Barter obj);
        void Remove(Guid id);
        Entities.Barter GetById(Guid id);
        void Update(Entities.Barter obj);
        IQueryable<Entities.Barter> Get(Expression<Func<Entities.Barter, bool>> predicate);
        Entities.Barter FirstOrDefault(Expression<Func<Entities.Barter, bool>> predicate);  
        int SaveChanges();
    }
}