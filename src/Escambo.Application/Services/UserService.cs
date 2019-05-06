using Escambo.Domain.Interfaces;
using Escambo.Domain.Models;

namespace Escambo.Application.Services
{
    public class UserService: GenericService<User>, IUserService
    {
        //private IUserRepository Repository{get{return (IUserRepository) _repository; }}
        public UserService(IUserRepository repository) : base(repository)
        {
        
        }

        //public User GetUserByItem(int id)
        //{
        //    return Repository.GetUserByItem(id);
        //}

    
        //public IEnumerable<User> FindPeopleWhoNeedMyItems(User user) => Repository.GetAll().Where(o => !o.Id.Equals(user.Id))
        //                                                                              .Where(p => p.WantedItems
        //                                                                              .Select(k => k.Name)
        //                                                                              .Any(l => user.MyItems
        //                                                                              .Select(c => c.Name)
        //                                                                              .Contains(l))).ToList();

    }
}