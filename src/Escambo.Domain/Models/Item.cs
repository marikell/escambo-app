namespace Escambo.Domain.Models
{
    public class Item: Entity
    {
        public string Name { get; set; }
        public int IdOwner { get; set; }

        
    }
}