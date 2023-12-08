namespace DreamTech.Model
{
    public class Employee 
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeNic { get; set; }
        public string? EmployeeCode { get; set; }
        public User? User { get; set; }
    }
}
