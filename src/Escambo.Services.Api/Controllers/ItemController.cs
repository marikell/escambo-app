using Escambo.Application;
using Escambo.Services.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private IItemService _service;

        public ItemController(IItemService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] ItemViewModel model)
        {

        }

        [HttpPut("{id}")]
        public void Put([FromBody] ItemViewModel model)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
