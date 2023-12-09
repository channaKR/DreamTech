using DreamTech.Model;
using Microsoft.EntityFrameworkCore;

namespace DreamTech.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product>products {get; set;}
        public DbSet<Customer> customers { get; set;}   
        public DbSet<Sealer> sealers { get; set;}
        public DbSet<Employee> employees { get; set;}
        public DbSet<User> users  { get; set;}


        


    }
}
