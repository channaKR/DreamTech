
using Microsoft.EntityFrameworkCore;

namespace DreamTech.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }



        


    }
}
