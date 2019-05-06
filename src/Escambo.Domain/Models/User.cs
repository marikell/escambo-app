using Escambo.Domain.Core.Models;
using System.Collections;
using System.Collections.Generic;

namespace Escambo.Domain.Models
{
    public class User: Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Item> Items { get; set; }
    }
}
