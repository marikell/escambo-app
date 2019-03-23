using Escambo.Application;
using Escambo.Application.Services;
using Escambo.Domain.Models;
using Escambo.Tests.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

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

            for (int i = 0; i < expectedUsers.Count; i++)
            {
                Assert.Equal(expectedUsers[i].Id, userWhoNeedsItems[i].Id);
            }

        }
    }
}
