using Escambo.Domain.Models;
using Escambo.Application.Services;
using System;
using System.Collections.Generic;
using Xunit;
using Escambo.Tests.Repository;
using Escambo.Domain.Interfaces;
using Escambo.Application;
using System.Linq;

namespace Escambo.Tests
{
    public class UserTest
    {
        [Fact]
        public void ShouldFindPeopleWhoNeedsMyItems()
        {          
            IUserService userService = new UserService(new UserFakeRepository()); 

            List<User> expectedUsers = UserBaseData.ExpectedShouldFindPeopleWhoNeedsMyItemsTest;

            var userWhoNeedsItems = userService.FindPeopleWhoNeedMyItems(UserBaseData.AllUsers[0]).ToList();          
            
            Assert.Equal(expectedUsers.Count, userWhoNeedsItems.Count);
            
            for(int i = 0; i < expectedUsers.Count; i++)
            {
                Assert.Equal(expectedUsers[i].Id, userWhoNeedsItems[i].Id);
            }            
        }
    }
}
