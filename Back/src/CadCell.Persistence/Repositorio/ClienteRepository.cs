using System.Threading.Tasks;
using CadCell.Domain.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CadCell.Persistence.InterfaceRepositorio;
using CadCell.Persistence.DataContext;
using CadCell.Persistence.Repositorio;

namespace CadCell.Persistence
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly CadCellContext _context;
        public ClienteRepository(CadCellContext context)
        {
            _context = context;
        }

        public async Task<Cliente[]> GetAllClienteByEquipamentosAsync(string equipamento)
        {
            IQueryable<Cliente> query = _context.Clientes;
            query = query.OrderBy(e => e.Id);
                          //.Where(e => e.Equipamento.ToLower().Contains(Equipamento.ToLower));

            return await query.ToArrayAsync();  
        }

        public async Task<Cliente[]> GetAllClientesAsync()
        {
            IQueryable<Cliente> query = _context.Clientes;
            query = query.OrderBy(e => e.Id);

            return await query.ToArrayAsync();
        }

        public async Task<Cliente> GetAllClienteByIdAsync(int clienteId)
        {
            IQueryable<Cliente> query = _context.Clientes;
            query = query.OrderBy(e => e.Id)
                         .Where(e => e.Id == clienteId);

            return await query.FirstOrDefaultAsync();    
        }
    }
}