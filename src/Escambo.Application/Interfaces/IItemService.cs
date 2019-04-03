using Escambo.Domain.Models;

namespace Escambo.Application
{
    public interface IItemService: IService<Item>
    {
        Item Get(int id);

        void ExchangeItem(int id1, int id2, User user1, User user2);
    }
}