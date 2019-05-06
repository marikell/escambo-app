using System;
using System.Collections.Generic;
using User.Application.Interfaces;
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
        }

        public void Update(Domain.Entities.User user)
        {
            _repository.Update(user);
        }
    }
}
