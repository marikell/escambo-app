using Escambo.Domain.Core.Models;
using Escambo.Domain.Enums;
using System;

namespace Escambo.Domain.Models
{
    //TODO INSERIR COLUNA SE O OBJETO ESTÁ OCUPADO
    public class Item: Entity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
    }
}
