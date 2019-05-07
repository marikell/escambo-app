using Barter.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Barter.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarterController : ControllerBase
    {
        protected IBarterService _service;
        public BarterController(IBarterService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Domain.Entities.Barter model)
        {
            try
            {
                if (model.HasFinished) { throw new Exception("This barter has already ended."); }


                //User.Domain.Entities.User user = _service.FirstOrDefault(o => o.Email == model.Email);

                //if (user == null)
                //{
                //    _service.Add(model);
                //    return StatusCode((int)HttpStatusCode.OK, "User was created!");
                //}

                return StatusCode((int)HttpStatusCode.OK, "");

            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Barter.Domain.Entities.Barter> Get(Guid id)
        {
            try
            {
                //return _service.FirstOrDefault(o => o.Email == email);
                return null;
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _service.Remove(id);

                return StatusCode((int)HttpStatusCode.OK, "Barter deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
