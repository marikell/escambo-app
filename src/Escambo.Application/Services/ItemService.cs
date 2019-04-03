using System;
using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Application.Services
{
    public class ItemService: Service<Item>, IItemService
    {
        private IItemRepository Repository{get{return (IItemRepository) _repository; }}
        public ItemService(IItemRepository repository) : base(repository)
        {
            
        }

        public Item Get(int id)
        {
            return Repository.Get(id);
        }

        public void ExchangeItem(int id1, int id2, User user1, User user2)
        {
            Repository.ExchangeItem(id1, id2, ref user1, ref user2);
        }
    }
}