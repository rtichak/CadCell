using System;
using System.Collections.Generic;

namespace CadCell.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Clientes { get; set; }

        public DateTime? DataCadastro { get; set; }

        public string Endereco { get; set; }

        public string Equipamento { get; set; }

        public string Telefone { get; set; }

        public string ImageURL { get; set; }

        public string Defeito { get; set; }

        public string Email { get; set; }

        public IEnumerable<Equipamento> Equipamentos { get; set; }

    }
}