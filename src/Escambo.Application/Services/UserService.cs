using System;
using System.Collections.Generic;
using System.Linq;
using Escambo.Domain.Models;

namespace Escambo.Application.Services
{
    public class UserService
    {
        public List<User> FindPeopleWhoNeedMyItems(User user, List<User> allUsers) => allUsers.Where(o => !o.Id.Equals(user.Id))
                                                                                      .Where(p => p.WantedItems
                                                                                      .Select(k => k.Name)
                                                                                      .Any(l => user.MyItems
                                                                                      .Select(c => c.Name)
                                                                                      .Contains(l))).ToList();

    }
}