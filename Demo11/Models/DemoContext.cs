using Microsoft.EntityFrameworkCore;

namespace Demo11.Models
{
    public class DemoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set;}

        public DbSet<Detail> Details { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-32\\SQLEXPRESS;" +
                "Initial Catalog=Lab11DB; Integrated Security=True;trustservercertificate=True");
        }

    }
}
