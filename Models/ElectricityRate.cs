namespace smart_city_dotnetcore.Models
{
    public class ElectricityRate
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Value { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}