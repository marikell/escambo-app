using Barter.Application.Interfaces;
using Barter.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace User.Application.Services
{
    public class BarterService : IBarterService
    {
        protected IBarterRepository _repository;
        public BarterService(IBarterRepository repository)
        {
            _repository = repository;
        }

        public void Add(Barter.Domain.Entities.Barter barter)
        {
            _repository.Add(barter);
            _repository.SaveChanges();
        }

        public Barter.Domain.Entities.Barter FirstOrDefault(Expression<Func<Barter.Domain.Entities.Barter, bool>> predicate)
        {
            return _repository.FirstOrDefault(predicate);
        }

        public IEnumerable<Barter.Domain.Entities.Barter> Get(Expression<Func<Barter.Domain.Entities.Barter, bool>> predicate)
        {
            return _repository.Get(predicate);
        }
        public IEnumerable<Barter.Domain.Entities.Barter> GetAll()
        {
            return _repository.GetAll();
        }

        public Barter.Domain.Entities.Barter GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
            _repository.SaveChanges();
        }

        public void Update(Barter.Domain.Entities.Barter barter)
        {
            _repository.Update(barter);
            _repository.SaveChanges();
        }
    }
}
