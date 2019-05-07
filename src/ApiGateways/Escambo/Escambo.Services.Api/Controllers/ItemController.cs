using Escambo.Application;
using Escambo.Domain.Entities;
using Escambo.Domain.Enums;
using Escambo.Services.Api.Dto;
using Escambo.Services.Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : GenericController<Item>
    {
        public ItemController(IItemService service) : base(service) { }

        [HttpPost]
        [Route("barter")]
        public ActionResult BarterItems([FromBody] BarterDto model)
        {
            try
            {
                //TODO IMPLEMENTAR UM MANIPULADOR DE ERROS DE MODEL
                //TODO INSERIR VALIDAÇÃO SE O ITEM ESTÁ DISPONÍVEL
                Item itemReceived = _service.GetById(model.ItemReceivedId);

                Item itemOffered = _service.GetById(model.ItemOfferedId);

                if((itemReceived == null || itemOffered == null)) { return StatusCode((int)HttpStatusCode.OK, "Maybe there are invalid items."); }

                if (itemOffered.Type != ItemType.Have) { return StatusCode((int)HttpStatusCode.OK, "You can't offer what you don't own."); }

                var response = new RequestHelper($"{ApiHelper.GetUserApi()}/api/user/p0", model.UserEmailOffering).DoGet();
                AccountDto accountDto = JsonConvert.DeserializeObject<AccountDto>(response.Message);

                if (accountDto == null) { return StatusCode((int)HttpStatusCode.OK, "This user doesn't exist in the database"); }

                if(itemOffered.UserId != accountDto.Id) { return StatusCode((int)HttpStatusCode.OK, "User and Item offered doesn't their id."); }

                var responseBarter = new RequestHelper($"{ApiHelper.GetBarterApi()}/api/barter")
                                               .DoPost(JsonConvert.SerializeObject(model));

                return StatusCode((int)responseBarter.StatusCode, responseBarter.Message);

            }
            catch (WebException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        //TODO Fazer método que finaliza uma troca passando o id dela

        [HttpPost]
        [Route("create")]
        public ActionResult CreateItemValidatingUser([FromBody] ItemDto model)
        {
            try
            {
                var response = new RequestHelper($"{ApiHelper.GetUserApi()}/api/user/p0", model.UserEmail).DoGet();
                AccountDto accountDto = JsonConvert.DeserializeObject<AccountDto>(response.Message);

                if (accountDto == null) { return StatusCode((int)HttpStatusCode.OK, "This user doesn't exist in the database"); }

                Item item = new Item
                {
                    Description = model.Description,
                    UserId = accountDto.Id,
                    Name = model.Name,
                    Type = model.Type,
                    Hired = false
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
