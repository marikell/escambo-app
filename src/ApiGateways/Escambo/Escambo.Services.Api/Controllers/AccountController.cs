using Escambo.Services.Api.Dto;
using Escambo.Services.Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public ActionResult Post([FromBody] AccountDto model)
        {
            try
            {
                var response = new RequestHelper($"{ApiHelper.GetUserApi()}/api/user")
                                                .DoPost(JsonConvert.SerializeObject(model));

                return StatusCode((int)response.StatusCode, response.Message);
            }
            catch (WebException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
