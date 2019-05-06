using Escambo.Application;
using Escambo.Application.Services;
using Escambo.Domain.Models;
using Escambo.Tests.Repository;
using System.Linq;
using Xunit;

namespace Escambo.Tests
{
    public class EscamboTest
    {
        [Fact]
        public void ExchangeItem()
        {
            //IItemService itemService = new ItemService(new ItemFakeRepository());
            //IUserService userService = new UserService(new UserFakeRepository());

            //User user1 = userService.GetUserByItem(1);
            //User user2 = userService.GetUserByItem(6);

            //itemService.ExchangeItem(1, 6, user1, user2);

            //var itemsUser1 = string.Join(",", user1.MyItems.OrderBy(o => o.Id).Select(o => o.Id).ToList());
            //var itemsUser2 = string.Join(",", user2.MyItems.OrderBy(o => o.Id).Select(o => o.Id).ToList());

            //var expectedUser1 = string.Join(",", UserBaseData.ExpectedItemsAfterExchange[0].MyItems.OrderBy(o => o.Id).Select(o => o.Id).ToList());
            //var expectedUser2 = string.Join(",", UserBaseData.ExpectedItemsAfterExchange[1].MyItems.OrderBy(o => o.Id).Select(o => o.Id).ToList());

            //Assert.Equal(expectedUser1, itemsUser1);
            //Assert.Equal(expectedUser2, itemsUser2);




        }
    }

}