using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using User.Application.Interfaces;
using User.Domain.Entities;
using User.Domain.Interfaces;

namespace User.Application.Services
{
    public class UserService : IUserService
    {
        protected IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Add(Domain.Entities.User user)
        {
            _repository.Add(user);
            _repository.SaveChanges();
        }

        public Domain.Entities.User FirstOrDefault(Expression<Func<Domain.Entities.User, bool>> predicate)
        {
            return _repository.FirstOrDefault(predicate);
        }

        public IEnumerable<Domain.Entities.User> Get(Expression<Func<Domain.Entities.User, bool>> predicate)
        {
            return _repository.Get(predicate);
        }
        public IEnumerable<Domain.Entities.User> GetAll()
        {
            return _repository.GetAll();
        }

        public Domain.Entities.User GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
            _repository.SaveChanges();
        }

        public void Update(Domain.Entities.User user)
        {
            _repository.Update(user);
            _repository.SaveChanges();
        }
    }
}
