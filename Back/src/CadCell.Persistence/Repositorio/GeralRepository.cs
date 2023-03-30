using System.Threading.Tasks;
using CadCell.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CadCell.Persistence.InterfaceRepositorio;
using CadCell.Persistence.DataContext;

namespace CadCell.Persistence.Repositorio
{
    public class GeralRepository : IGeralRepository
    {
        private readonly CadCellContext _context;
        public GeralRepository(CadCellContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public void DeleteRange<T>(T[] entityArray) where T : class
        {
            _context.RemoveRange(entityArray);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}