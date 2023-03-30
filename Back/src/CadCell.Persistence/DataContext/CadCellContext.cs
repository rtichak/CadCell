using System;
using CadCell.Domain;
using CadCell.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CadCell.Persistence.DataContext
{
    public class CadCellContext : DbContext
    {
       public CadCellContext(DbContextOptions<CadCellContext> options) : base(options){ }
       public DbSet<Cliente> Clientes { get; set; }

       public DbSet<Equipamento> Equipamentos { get; set; } 
    }
}