using System.Collections.Generic;
using System.Linq;
using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Tests.Repository
{
    public class ItemFakeRepository : IItemRepository
    {
        public void ExchangeItem(int id1, int id2, ref User user1, ref User user2)
        {
            Item item1 = ItemBaseData.AllItems.FirstOrDefault(o => o.Id == id1);
            Item item2 = ItemBaseData.AllItems.FirstOrDefault(o => o.Id == id2);

            List<Item> user1Items = new List<Item>();

            List<Item> user2Items = new List<Item>();

            foreach (var item in user1.MyItems)
            {
                if(item.Id != id1)
                {
                    user1Items.Add(item);
                }
            }

            user1Items.Add(item2);

            user1.MyItems = user1Items;

            foreach (var item in user2.MyItems)
            {
                if (item.Id != id2)
                {
                    user2Items.Add(item);
                }
            }

            user2Items.Add(item1);

            user2.MyItems = user2Items;

        }

        public Item Get(int id)
        {
            return ItemBaseData.AllItems.FirstOrDefault(o => o.Id == id);
        }

        public IQueryable<Item> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}