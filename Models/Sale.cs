namespace SmartCompany.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string? Group { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Summ { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
    }
}
