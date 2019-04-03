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

        public User GetUserByItem(int itemId)
        {
            foreach (var user in UserBaseData.AllUsers)
            {
                foreach (var item in user.MyItems)
                {
                    if (item.Id == itemId) { return user; }

                }
            }

            return null;
        }
    }
}