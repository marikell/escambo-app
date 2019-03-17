using Escambo.Domain.Models;
using Escambo.Application.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace Escambo.Tests
{
    public class EscamboTest
    {
        #region Properties
        private List<User> ExpectedUsers = new List<User>
        {
            new User
            {
               Id = 2,
               MyItems = new List<Item>(),
               Username = "retired",
               WantedItems = new List<Item>{new Item{Id = 2, Name = "book"}, new Item{Id = 3, Name = "tool"}}
            },
            new User
            {
                Id = 3,
                MyItems = new List<Item>(),
                Username = "housewife",
                WantedItems = new List<Item>{new Item{Id = 4, Name = "mixer"}}
            }
        };
        private List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                MyItems = new List<Item> { new Item { Id = 1, Name = "mixer" }, new Item { Id = 2, Name = "tool" } },
                Username = "student",
                WantedItems = new List<Item>()
            },
            new User
            {
               Id = 2,
               MyItems = new List<Item>(),
               Username = "retired",
               WantedItems = new List<Item>{new Item{Id = 2, Name = "book"}, new Item{Id = 3, Name = "tool"}}
            },
            new User
            {
                Id = 3,
                MyItems = new List<Item>(),
                Username = "housewife",
                WantedItems = new List<Item>{new Item{Id = 4, Name = "mixer"}}
            },
            new User
            {
                Id = 4,
                MyItems = new List<Item>(),
                Username = "husband",
                WantedItems = new List<Item>()
            }
        };

        #endregion

        [Fact]
        public void ShouldFindPeopleWhoNeedsMyItems()
        {            
            UserService userService = new UserService();

            var usersWhoNeedItems = userService.FindPeopleWhoNeedMyItems(Users[0], Users);
            
            Assert.Equal(2, usersWhoNeedItems.Count);
            Assert.Equal(ExpectedUsers[0].Id, usersWhoNeedItems[0].Id);
            Assert.Equal(ExpectedUsers[1].Id, usersWhoNeedItems[1].Id);          
            
        }
    }
}
