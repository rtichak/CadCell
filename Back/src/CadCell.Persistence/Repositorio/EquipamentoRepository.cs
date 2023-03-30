using System.Threading.Tasks;
using CadCell.Domain.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CadCell.Persistence.InterfaceRepositorio;
using CadCell.Persistence.DataContext;
using CadCell.Domain;

namespace CadCell.Persistence.Repositorio
{
    public class EquipamentosRepository : IEquipamentosRepository
    {
        private readonly CadCellContext _context;
        public EquipamentosRepository(CadCellContext context)
        {
            _context = context;
        }

        public async Task<Equipamento[]> GetAllEquipamentosByModeloAsync(string equipamento)
        {
            IQueryable<Equipamento> query = _context.Equipamentos;
            query = query.OrderBy(x => x.Id);
                        //  .Where(x => x.Modelo.ToLower().Contains(Modelo.ToLower));

            return await query.ToArrayAsync(); 

        }
        public async Task<Equipamento[]> GetAllEquipamentosAsync(string equipamento)
        {
            IQueryable<Equipamento> query = _context.Equipamentos;
            query = query.OrderBy(x => x.Id);

            return await query.ToArrayAsync();

        }
        public async Task<Equipamento> GetAllEquipamentoByIdAsync(int equipamentoId)
        {
            IQueryable<Equipamento> query = _context.Equipamentos;
            query = query.OrderBy(x => x.Id)
                         .Where(x => x.Id == equipamentoId);

            return await query.FirstOrDefaultAsync();  

        }

    }
}