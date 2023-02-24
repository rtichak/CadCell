using CadCell.API.model;
using Microsoft.EntityFrameworkCore;

namespace CadCell.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }
       public DbSet<Evento> Eventos { get; set; } 
    }
}