using Escambo.Domain.Models;

namespace Escambo.Domain.Interfaces
{
    public interface IItemRepository: IRepository<Item>
    {
        Item Get(int id);
        void ExchangeItem(int id1, int id2, ref User user1, ref User user2);



    }
}