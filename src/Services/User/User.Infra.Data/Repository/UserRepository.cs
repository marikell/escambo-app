using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using User.Domain.Interfaces;

namespace User.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly DbContext DbContext;
        protected readonly DbSet<Domain.Entities.User> DbSet;
        public UserRepository(DbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<Domain.Entities.User>();
        }

        public void Add(Domain.Entities.User obj)
        {
            DbSet.Add(obj);
        }

        public IQueryable<Domain.Entities.User> GetAll()
        {
            return DbSet;
        }

        public Domain.Entities.User GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }
        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        public void Update(Domain.Entities.User obj)
        {
            DbSet.Update(obj);
        }
    }
}
