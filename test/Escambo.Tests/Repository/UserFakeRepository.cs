using System;
using System.Collections.Generic;
using System.Linq;
using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Tests.Repository
{
    public class UserFakeRepository : IUserRepository
    {
        //public IQueryable<User> GetAll()
        //{
        //    //return UserBaseData.AllUsers.AsQueryable();
        //}

        //public User GetUserByItem(int itemId)
        //{
        //    foreach (var user in UserBaseData.AllUsers)
        //    {
        //        foreach (var item in user.MyItems)
        //        {
        //            if (item.Id == itemId) { return user; }

        //        }
        //    }

        //    return null;
        //}
        public void Add(User obj)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}