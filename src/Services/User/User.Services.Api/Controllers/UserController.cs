using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using User.Application.Interfaces;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Post([FromBody] User.Domain.Entities.User model)
        {
            try
            {
                User.Domain.Entities.User user = _service.FirstOrDefault(o => o.Email == model.Email);

                if (user == null)
                {
                    _service.Add(model);
                    return StatusCode((int)HttpStatusCode.OK, "User was created!");
                }

                return StatusCode((int)HttpStatusCode.OK, "User already exists in db");



            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<User.Domain.Entities.User> Get(Guid id)
        {
            try
            {
                return _service.GetById(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public void Put([FromBody] User.Domain.Entities.User model)
        {
            try
            {
                _service.Update(model);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            try
            {
                _service.Remove(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
