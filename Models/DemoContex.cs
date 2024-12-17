using Microsoft.EntityFrameworkCore;

namespace Examen05.Models
{
    public class DemoContex: DbContext
    {

        public DbSet<Productos> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MANU-PC; " +
                "Database=Examen05; Integrated Security=True;" +
                "Trust Server Certificate=True ");
        }


    }
}
