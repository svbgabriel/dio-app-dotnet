using Microsoft.EntityFrameworkCore;

namespace CursoDIOMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=dio;Username=dio;Password=dio");
        }
    }
}
