
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sealer>()
                    .HasKey(se => new { se.SealerCode});
            modelBuilder.Entity<Sealer>()
                    .HasOne(se => se.User)
                    .WithOne(u => u.Sealer);

            modelBuilder.Entity<Sealer>()
                .HasMany(se => se.Product)
                .WithMany(pr => pr.Sealer);
                
                   



        }


    }
}
