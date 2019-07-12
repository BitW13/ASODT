using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASODT.Route.DataAccess.Repositories.Interfaces
{
    public interface IRepository <T>
        where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> Get();
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}