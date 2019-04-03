using System.Collections.Generic;
using Escambo.Domain.Models;

namespace Escambo.Tests
{
    public static class ItemBaseData
    {
        public static List<Item> AllItems => new List<Item>
        {
            new Item { Id = 1, Name = "mixer" }, 
            new Item { Id = 2, Name = "tool" },
            new Item{Id = 3, Name = "book"}, 
            new Item{Id = 4, Name = "tool"},
            new Item{Id = 5, Name = "mixer"},
            new Item{Id = 6, Name = "book"}

        };

            }
}