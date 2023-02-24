using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadCell.API.Data;
using CadCell.API.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadCell.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos ;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
