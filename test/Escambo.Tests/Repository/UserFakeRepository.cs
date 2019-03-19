using System.Collections.Generic;
using System.Linq;
using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Tests.Repository
{
    public class UserFakeRepository : IUserRepository
    {
        public IQueryable<User> GetAll()
        {
            return UserBaseData.AllUsers.AsQueryable();
        }
    }
}