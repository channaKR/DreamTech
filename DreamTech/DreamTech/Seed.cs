using DreamTech.Data;
using DreamTech.Model;

namespace DreamTech
{
    public class Seed
    {   private readonly DataContext _context;
        public Seed (DataContext DataContext ) 
        {
            _context = DataContext;
        }
        public void SeedDataContext()
        {
            
            
        }
    }
}
