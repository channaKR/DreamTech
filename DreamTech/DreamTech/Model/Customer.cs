namespace DreamTech.Model
{
    public class Customer : User
    {
        public int CustomerID { get; set; } 
        public string? CustomerName { get; set; }
        public string? CustomerNic { get; set; }
        public string? CustomerCode { get; set; }
    }
}
