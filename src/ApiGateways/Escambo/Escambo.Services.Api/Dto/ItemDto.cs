using Escambo.Domain.Enums;
using System;

namespace Escambo.Services.Api.Dto
{
    public class ItemDto
    {
        public string Description { get; set; }
        public string UserEmail { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }
    }
}
