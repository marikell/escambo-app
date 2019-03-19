using System.Collections.Generic;

namespace Escambo.Application
{
    public interface IService<T> where T:class
    {
        IEnumerable<T> GetAll();
    }
}