using System.Threading.Tasks;
using CadCell.Domain;
using CadCell.Domain.Models;

namespace CadCell.Persistence.InterfaceRepositorio
{
    public interface IClienteRepository
    {
        Task<Cliente[]> GetAllClienteByEquipamentosAsync(string equipamento);
        Task<Cliente[]> GetAllClientesAsync();
        Task<Cliente> GetAllClienteByIdAsync(int clienteId);
    }
}