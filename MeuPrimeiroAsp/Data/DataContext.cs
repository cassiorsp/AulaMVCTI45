using MeuPrimeiroAsp.Models;
using Microsoft.EntityFrameworkCore;
using TesteEntity.Models;

namespace MeuPrimeiroAsp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<RepresentanteModel> Representantes { get; set;}
        public DbSet<Usuario> Usuarios { get; set; } = default!;
    }
}
