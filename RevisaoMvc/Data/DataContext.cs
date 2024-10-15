using Microsoft.EntityFrameworkCore;
using RevisaoMvc.Models;

namespace RevisaoMvc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }



        //DBSet

        public DbSet<FornecedorModel> Fornecedores { get; set;}
    }
}
