using Escambo.Application;
using Escambo.Domain.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Escambo.Services.Api.Controllers
{
    public class GenericController<TEntity>:ControllerBase where TEntity:Entity
    {
        protected IGenericService<TEntity> _service;

        public GenericController(IGenericService<TEntity> service)
        {
            _service = service;
        }

        [HttpPost]
        public void Post([FromBody] TEntity model)
        {
            try
            {
                _service.Add(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<TEntity> Get(Guid id)
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
        public void Put([FromBody] TEntity model)
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
