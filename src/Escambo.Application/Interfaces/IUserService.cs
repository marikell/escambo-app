using System.Collections.Generic;
using Escambo.Domain.Models;

namespace Escambo.Application
{
    public interface IUserService: IGenericService<User>
    {
        //IEnumerable<User> FindPeopleWhoNeedMyItems(User user);
        //User GetUserByItem(int id);

    }
}