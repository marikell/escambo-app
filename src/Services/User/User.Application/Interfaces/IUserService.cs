using System;
using System.Collections.Generic;

namespace User.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<Domain.Entities.User> GetAll();
        void Add(Domain.Entities.User user);
        void Remove(Guid id);
        Domain.Entities.User GetById(Guid id);
        void Update(Domain.Entities.User user);
    }
}
