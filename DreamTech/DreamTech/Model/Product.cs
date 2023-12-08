namespace DreamTech.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public ICollection<Sealer>? seals { get; set; }
        public double? Price { get; set; }
    }
}
