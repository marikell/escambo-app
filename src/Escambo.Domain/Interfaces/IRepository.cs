using Escambo.Domain.Core.Models;
using System;
using System.Linq;

namespace Escambo.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity:Entity
    {
        IQueryable<TEntity> GetAll();
        void Add(TEntity obj);
        void Remove(Guid id);
        TEntity GetById(Guid id);
        void Update(TEntity obj);
        int SaveChanges();
    }
}