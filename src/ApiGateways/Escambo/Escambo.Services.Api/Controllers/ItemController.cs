using Escambo.Application;
using Escambo.Domain.Models;
using Escambo.Services.Api.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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
