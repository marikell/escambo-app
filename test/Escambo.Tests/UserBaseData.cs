using Escambo.Domain.Models;
using System.Collections.Generic;

namespace Escambo.Tests
{
    public static class UserBaseData
    {
        public static List<User> AllUsers => new List<User>{
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
                WantedItems = new List<Item>{new Item{Id = 3, Name = "book"}, new Item{Id = 4, Name = "tool"}}
                },
                new User
                {
                    Id = 3,
                    MyItems = new List<Item>(),
                    Username = "housewife",
                    WantedItems = new List<Item>{new Item{Id = 5, Name = "mixer"}}
                },
                new User
                {
                    Id = 4,
                    MyItems = new List<Item>(),
                    Username = "husband",
                    WantedItems = new List<Item>()
                }};

        public static List<User> ExpectedShouldFindPeopleWhoNeedsMyItemsTest => new List<User>
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
    }
}