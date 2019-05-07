using Barter.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Barter.Infra.Data.Repository
{
    public class BarterRepository : IBarterRepository
    {
        protected readonly DbContext DbContext;
        protected readonly DbSet<Domain.Entities.Barter> DbSet;
        public BarterRepository(DbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<Domain.Entities.Barter>();
        }

        public void Add(Domain.Entities.Barter obj)
        {
            DbSet.Add(obj);
        }

        public IQueryable<Domain.Entities.Barter> GetAll()
        {
            return DbSet;
        }

        public Domain.Entities.Barter GetById(Guid id)
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

        public IQueryable<Domain.Entities.Barter> Get(Expression<Func<Domain.Entities.Barter, bool>> predicate)
        {
            return DbSet.Where(predicate);

        }
        public void Update(Domain.Entities.Barter obj)
        {
            DbSet.Update(obj);
        }
        public Domain.Entities.Barter FirstOrDefault(Expression<Func<Domain.Entities.Barter, bool>> predicate)
        {
            return Get(predicate).FirstOrDefault();
        }
    }
}
