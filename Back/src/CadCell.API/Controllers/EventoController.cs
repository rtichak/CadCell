using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadCell.API.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadCell.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
             new Evento (){
                EventoId = 1,
                Cliente = "Ronaldo",
                Data = DateTime.Now.AddDays(2).ToString(),
                Endereco = "Rua 4",
                Equipamento = "celular",
                ImageURL ="foto.png"
              },
              new Evento (){
                EventoId = 2,
                Cliente = "Elaine",
                Data = DateTime.Now.AddDays(2).ToString(),
                Endereco = "Rua 4",
                Equipamento = "celular",
                ImageURL ="foto.png"
              }
            };    
        public EventoController()
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet ("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "exemplo de Put";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "exemplo de delete";
        }
    }
}
