using System;
using System.Collections.Generic;
using System.Linq;
using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Application.Services
{
    public class UserService: Service<User>, IUserService
    {
        private IUserRepository Repository{get{return (IUserRepository) _repository; }}
        public UserService(IRepository<User> repository) : base(repository)
        {

        }

        public IEnumerable<User> FindPeopleWhoNeedMyItems(User user) => Repository.GetAll().Where(o => !o.Id.Equals(user.Id))
                                                                                      .Where(p => p.WantedItems
                                                                                      .Select(k => k.Name)
                                                                                      .Any(l => user.MyItems
                                                                                      .Select(c => c.Name)
                                                                                      .Contains(l))).ToList();

    }
}