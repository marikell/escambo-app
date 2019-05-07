using Escambo.Application;
using Escambo.Domain.Models;
using Escambo.Services.Api.Dto;
using Escambo.Services.Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : GenericController<Item>
    {
        public ItemController(IItemService service) : base(service) { }
        [HttpPost]
        [Route("create")]
        public ActionResult CreateItemValidatingUser([FromBody] ItemDto model)
        {
            try
            {
                var response = new RequestHelper($"{ApiHelper.GetUserApi()}/api/user/p0", model.UserEmail).DoGet();
                AccountDto accountDto = JsonConvert.DeserializeObject<AccountDto>(response.Message);

                if (accountDto == null) { return StatusCode((int)HttpStatusCode.OK, "The user doesn't exist in the database"); }

                Item item = new Item
                {
                    Description = model.Description,
                    UserId = accountDto.Id,
                    Name = model.Name,
                    Type = model.Type
                };

                _service.Add(item);

                return StatusCode((int)HttpStatusCode.OK, "Item was created.");
            }
            catch (WebException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
