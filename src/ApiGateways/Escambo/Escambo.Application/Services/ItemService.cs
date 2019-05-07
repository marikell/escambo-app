using System;
using Escambo.Domain.Entities;
using Escambo.Domain.Interfaces;

namespace Escambo.Application.Services
{
    public class ItemService : GenericService<Item>, IItemService
    {
        public ItemService(IItemRepository repository) : base(repository)
        {

        }

        //public Item Get(int id)
        //{
        //    return Repository.Get(id);
        //}

        //public void ExchangeItem(int id1, int id2, User user1, User user2)
        //{
        //    Repository.ExchangeItem(id1, id2, ref user1, ref user2);
        //}
    }
}