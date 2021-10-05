using Pets.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pets.Domain.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T item);
        Task<T> Update(T item);
        Task<bool> Delete(int id);
        Task<bool> Exist(int id);
    }
}
