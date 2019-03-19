using System.Collections.Generic;
using Escambo.Domain.Models;

namespace Escambo.Application
{
    public interface IUserService: IService<User>
    {
        IEnumerable<User> FindPeopleWhoNeedMyItems(User user); 
    }
}