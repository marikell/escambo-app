using System;
using System.Linq;
using Escambo.Domain.Core.Models;
using Escambo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Escambo.Infra.Data.Models
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DbContext DbContext;
        protected readonly DbSet<TEntity> DbSet;
        public GenericRepository(DbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
        }

        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public TEntity GetById(Guid id)
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

        public void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }
    }
}