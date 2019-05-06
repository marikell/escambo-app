﻿using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;
using Escambo.Infra.Data.Models;

namespace Escambo.Infra.Data.Repository
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(EscamboContext context) : base(context) { }

    }
}
