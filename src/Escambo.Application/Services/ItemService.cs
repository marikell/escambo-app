using System;
using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Application.Services
{
    public class ItemService: Service<Item>, IItemService
    {
        public ItemService(IItemRepository repository) : base(repository)
        {
            
        }
    }
}