using Escambo.Application;
using Escambo.Application.Services;
using Escambo.Domain.Interfaces;
using Escambo.Infra.CrossCutting.IoC.Interfaces;
using Escambo.Infra.Data.Repository;
using SimpleInjector;

namespace Escambo.Services.Api
{
    public class Bootstrap : IIoC
    {
        public void Register(Container container)
        {
            
            container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
            container.Register<IItemRepository, ItemRepository>(Lifestyle.Scoped);

            container.Register<IUserService, UserService>(Lifestyle.Scoped);
            container.Register<IItemService, ItemService>(Lifestyle.Scoped);

            
        }
    }
}
