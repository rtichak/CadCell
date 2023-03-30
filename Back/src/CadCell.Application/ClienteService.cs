using System;
using System.Threading.Tasks;
using CadCell.Domain.Models;
//using CadCell.Application.Interface;
using CadCell.Persistence.InterfaceRepositorio;

namespace CadCell.Application
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _iclienterepository;
        private readonly IGeralRepository _igeralRepository;
        public ClienteService(IGeralRepository igeral, IClienteRepository icliente)
        {
            _igeralRepository = igeral;
            _iclienterepository = icliente;
        }

        public async Task<Cliente> AddClientes(Cliente model)
        {
            try
            {
                _igeralRepository.Add<Cliente>(model);
                if (await _igeralRepository.SaveChangesAsync())
                {
                    return await _iclienterepository.GetAllClienteByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> UpdateCliente(int clienteId, Cliente model)
        {
            try
            {
                var clientes = await _iclienterepository.GetAllClienteByIdAsync(clienteId);
                if (clientes == null) return null;
                model.Id = clientes.Id;

                _igeralRepository.Update(model);
                if (await _igeralRepository.SaveChangesAsync())
                {
                    return await _iclienterepository.GetAllClienteByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteCliente(int clienteId)
        {
            try
            {
                var clientes = await _iclienterepository.GetAllClienteByIdAsync(clienteId);
                if (clientes == null) throw new Exception("Cliente para delete não encontrado");

                _igeralRepository.Delete<Cliente>(clientes);

                return await _igeralRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente[]> GetAllclientesAsync()
        {
            try
            {
                var clientes = await _iclienterepository.GetAllClientesAsync();
                if (clientes == null) return null;

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente[]> GetAllClienteByEquipamentosAsync(string equipamento)
        {
            try
            {
                var clientes = await _iclienterepository.GetAllClienteByEquipamentosAsync(equipamento);
                if (clientes == null) return null;

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Cliente> GetAllClienteByIdAsync(int clienteId)
        {
            try
            {
                var clientes = await _iclienterepository.GetAllClienteByIdAsync(clienteId);
                if (clientes == null) return null;

                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<Cliente[]> GetAllClientesAsync()
        {
            throw new NotImplementedException();
        }
    }
}