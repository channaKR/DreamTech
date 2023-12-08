namespace DreamTech.Model
{
    public class Customer 
    {
        public int CustomerID { get; set; } 
        public string? CustomerName { get; set; }
        public string? CustomerNic { get; set; }
        public string? CustomerCode { get; set; }
        public User? User { get; set; }
    }
}
