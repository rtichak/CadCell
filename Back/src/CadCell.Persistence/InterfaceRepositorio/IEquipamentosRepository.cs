using System.Threading.Tasks;
using CadCell.Domain;
using CadCell.Domain.Models;

namespace CadCell.Persistence.InterfaceRepositorio
{
    public interface IEquipamentosRepository
    {
        Task<Equipamento[]> GetAllEquipamentosByModeloAsync(string equipamento);
        Task<Equipamento[]> GetAllEquipamentosAsync(string equipamento);
        Task<Equipamento> GetAllEquipamentoByIdAsync(int equipamentoId);
    }
}