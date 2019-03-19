using System.Linq;
using Escambo.Domain.Interfaces;

namespace Escambo.Infra.Data.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {        
        public IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}