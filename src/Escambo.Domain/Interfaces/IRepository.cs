using System.Linq;

namespace Escambo.Domain.Interfaces
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
    }
}