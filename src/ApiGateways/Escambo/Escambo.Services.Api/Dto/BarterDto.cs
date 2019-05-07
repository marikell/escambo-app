using System;

namespace Escambo.Services.Api.Dto
{
    public class BarterDto
    {
        public Guid ItemOfferedId { get; set; }
        public Guid ItemReceivedId { get; set; }
        public DateTime Date { get; set; }
        public bool HasFinished { get; set; }

        public string UserEmailOffering { get; set; }
    }
}
