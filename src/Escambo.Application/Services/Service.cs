using System.Collections.Generic;
using Escambo.Domain.Interfaces;

namespace Escambo.Application
{
    public class Service<T> : IService<T> where T : class
    {
        protected IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {   
            _repository = repository;
        }
        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }

}