using System;
using System.Collections.Generic;
using Escambo.Domain.Core.Models;
using Escambo.Domain.Interfaces;

namespace Escambo.Application
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : Entity
    {
        protected IRepository<TEntity> _repository;
        public GenericService(IRepository<TEntity> repository)
        {   
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
            _repository.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
            _repository.SaveChanges();
        }
        public void Update(TEntity obj)
        {
            _repository.Update(obj);
            _repository.SaveChanges();
        }
    }

}