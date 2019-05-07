using Barter.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Barter.Services.Api.Controllers
{
    [Route("api/barter")]
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

                model.Date = DateTime.Now;
                model.HasFinished = false;

                _service.Add(model);

                return StatusCode((int)HttpStatusCode.OK, "Barter was created!");

            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("finish-barter/{id}")]
        public ActionResult FinishBarter(Guid id)
        {
            try
            {
                Domain.Entities.Barter barter = _service.GetById(id);

                if (barter == null) { throw new Exception("This barter doesn't exists."); }

                _service.FinishBarter(id);

                return StatusCode((int)HttpStatusCode.OK, "Barter finished");

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
                return StatusCode((int)HttpStatusCode.OK, _service.GetById(id));
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
