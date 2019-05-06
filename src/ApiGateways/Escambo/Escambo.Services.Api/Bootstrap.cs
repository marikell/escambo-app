using Escambo.Application;
using Escambo.Application.Services;
using Escambo.Domain.Interfaces;
using Escambo.Infra.CrossCutting.IoC.Interfaces;
using Escambo.Infra.Data;
using Escambo.Infra.Data.Helpers;
using Escambo.Infra.Data.Models;
using Escambo.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using SimpleInjector;

namespace Escambo.Services.Api
{
    public class Bootstrap : IIoCRegister
    {
        public void Register(Container container)
        {

            container.Register(() => { return DbHelper.GetEscamboContext(); }, Lifestyle.Scoped);

            //container.Register<IDbContextProvider, EscamboContext>(Lifestyle.Scoped);

            //container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
            container.Register<IItemRepository, ItemRepository>(Lifestyle.Scoped);

            //container.Register<IUserService, UserService>(Lifestyle.Scoped);
            container.Register<IItemService, ItemService>(Lifestyle.Scoped);            
        }
    }
}
