using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using User.Application.Interfaces;

namespace Escambo.Services.Api.Controllers
{
    [Route("api/user")]
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

        [HttpGet("{email}")]
        public ActionResult<User.Domain.Entities.User> Get(string email)
        {
            try
            {
                return _service.FirstOrDefault(o => o.Email == email);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] User.Domain.Entities.User model)
        {
            try
            {
                _service.Update(model);

                return StatusCode((int)HttpStatusCode.OK, "User updated.");
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

                return StatusCode((int)HttpStatusCode.OK, "User deleted.");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
