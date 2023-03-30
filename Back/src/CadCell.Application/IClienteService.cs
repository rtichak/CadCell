using System;
using System.Threading.Tasks;
using CadCell.Domain.Models;
//using CadCell.Application.Interface;
using CadCell.Persistence.InterfaceRepositorio;
using CadCell.Persistence.Repositorio;


namespace CadCell.Application
{
    public interface IClienteService
    {
        Task<Cliente> AddClientes(Cliente model);
        Task<Cliente> UpdateCliente(int clienteId, Cliente model);
        Task<bool> DeleteCliente(int clienteId);

        Task<Cliente[]> GetAllClienteByEquipamentosAsync(string equipamento);
        Task<Cliente[]> GetAllClientesAsync();
        Task<Cliente> GetAllClienteByIdAsync(int clienteId);
    }
}