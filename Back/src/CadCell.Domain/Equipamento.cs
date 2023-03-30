using System;
using CadCell.Domain.Models;

namespace CadCell.Domain
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Emei { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public  string Estado { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }
    }
}