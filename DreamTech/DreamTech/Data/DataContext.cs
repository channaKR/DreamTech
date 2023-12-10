
using DreamTech.Model;
using Microsoft.EntityFrameworkCore;

namespace DreamTech.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Sealer> sealers { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }

     


    }
}
