using Microsoft.EntityFrameworkCore;

namespace Lab11.Models

{


    // Funciona como contenedor de todas mis clases (de todas las tablas) se tiene que heredar de entity framework
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext>options)
        :base(options)
        {
        }
        public DbSet <Product> Products { get; set; }
        public DbSet <Detail> Details { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
