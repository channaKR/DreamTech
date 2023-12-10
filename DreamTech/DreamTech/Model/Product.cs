namespace DreamTech.Model
{
    public class Product
    {
        public int? ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductCode { get; set; }
        public double? Price { get; set; }
        public ICollection<Sealer>? Sealer { get; set; }
    }
}
