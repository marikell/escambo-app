using User.Domain.Core.Models;

namespace User.Domain.Entities
{
    public class User: Entity
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
