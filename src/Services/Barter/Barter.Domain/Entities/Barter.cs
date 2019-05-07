using Barter.Domain.Core.Models;
using System;

namespace Barter.Domain.Entities
{
    public class Barter : Entity
    {
        public Guid ItemOfferedId { get; set; }
        public Guid ItemReceivedId { get; set; }
        public DateTime Date { get; set; }
    }
}
