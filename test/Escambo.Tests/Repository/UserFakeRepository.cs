using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;
using System.Linq;

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