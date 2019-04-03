using Escambo.Domain.Models;

namespace Escambo.Domain.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
        User GetUserByItem(int itemId);
    }
}