namespace DreamTech.Model
{
    public class Sealer
    {
        public int SealerId { get; set; }
        public string SealerName { get; set; }
        public string SealerNic {  get; set; }
        public string SealerCode { get; set; } 
        public ICollection<Product> Product { get; set; }
        public User User { get; set;}

    }
}
