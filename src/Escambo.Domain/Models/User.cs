using Escambo.Domain.Core.Models;

namespace Escambo.Domain.Models
{
    public class User: Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
