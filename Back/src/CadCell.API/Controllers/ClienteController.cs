using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadCell.Persistence;
using CadCell.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CadCell.Persistence.DataContext;
using Microsoft.AspNetCore.Http;
//using CadCell.Application.Interface;
using CadCell.Application;

namespace CadCell.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;

        }

        [HttpGet]
        public async Task <IActionResult> Get()
        {
            try
            {
                var clientes = await clienteService.GetAllClientesAsync();
                if (clientes == null) return NotFound("nenhum Cliente encontrado.");

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar recuperar Cliente.Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
           try
            {
                var cliente = await clienteService.GetAllClienteByIdAsync(id);
                if (cliente == null) return NotFound("Nenhum Cliente encontrado.");

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar recuperar Cliente.Erro: {ex.Message}");
            }
        }

        [HttpGet("{equipamento}/equipamento")]
        public async Task<IActionResult> GetByEquipamento(string equipamento)
        {
           try
            {
                var cliente = await clienteService.GetAllClienteByEquipamentosAsync(equipamento);
                if (cliente == null) return NotFound("Nenhum Cliente encontrado.");

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar recuperar Cliente.Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Cliente model)
        {
            try
            {
                var cliente = await clienteService.AddClientes(model);
                if (cliente == null) return BadRequest("Nenhum Cliente encontrado.");

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar adicionar Cliente.Erro: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task <IActionResult> Put(int id, Cliente model)
        {
            try
            {
                var cliente = await clienteService.UpdateCliente(id, model);
                if (cliente == null) return BadRequest("Nenhum Cliente alterado.");

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar alterar Cliente.Erro: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (await clienteService.DeleteCliente(id)) 
                      {
                        return Ok("Deletado");
                      }     
                else
                       return BadRequest("Cliente Não Deletado");
            }
            catch (Exception ex)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Erro ao tentar deletar Cliente.Erro: {ex.Message}");
            }
        }
    }
}
