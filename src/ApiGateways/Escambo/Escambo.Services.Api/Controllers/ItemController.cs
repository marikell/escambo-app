using Escambo.Application;
using Escambo.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : GenericController<Item>
    {
        public ItemController(IItemService service) : base(service)
        {

        }
    }
}
