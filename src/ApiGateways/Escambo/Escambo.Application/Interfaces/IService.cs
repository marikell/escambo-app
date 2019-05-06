using Escambo.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace Escambo.Application
{
    public interface IGenericService<TEntity> where TEntity:Entity
    {
        IEnumerable<TEntity> GetAll();
        void Add(TEntity obj);
        void Remove(Guid id);
        TEntity GetById(Guid id);
        void Update(TEntity obj);
    }
}