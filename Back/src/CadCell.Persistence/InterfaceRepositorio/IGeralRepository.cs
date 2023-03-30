using System.Threading.Tasks;
using CadCell.Domain.Models;

namespace CadCell.Persistence.InterfaceRepositorio
{
    public interface IGeralRepository
    {
        void Add<T>(T entity) where T: class;
        void Update<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        void DeleteRange<T>(T[] entity) where T: class;
        Task<bool> SaveChangesAsync();

    }
}