using System;
using System.Linq;

namespace User.Domain.Interfaces
{
    public interface IUserRepository
    {

        IQueryable<Entities.User> GetAll();
        void Add(Entities.User obj);
        void Remove(Guid id);
        Entities.User GetById(Guid id);
        void Update(Entities.User obj);
        int SaveChanges();
    }
}