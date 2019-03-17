using System.Collections.Generic;

namespace Escambo.Domain.Models
{
    public class User: Entity
    {
        public string Username { get; set; }
        public ICollection<Item> WantedItems { get; set; }        
        public ICollection<Item> MyItems {get; set; }        
    }
}