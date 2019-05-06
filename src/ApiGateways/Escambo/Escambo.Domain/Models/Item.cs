using Escambo.Domain.Core.Models;
using System;

namespace Escambo.Domain.Models
{
    public class Item: Entity
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
    }
}
