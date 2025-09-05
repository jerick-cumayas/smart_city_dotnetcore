using System.ComponentModel.DataAnnotations.Schema;

namespace smart_city_dotnetcore.Models
{
    public class ElectricityConsumption
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        [ForeignKey("HouseId")]
        public House? House { get; set; }
        public double StartReading { get; set; }
        public double EndReading { get; set; }
        public double Consumption { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}