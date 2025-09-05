using System.ComponentModel.DataAnnotations.Schema;

namespace smart_city_dotnetcore.Models
{
    public class ElectricityBalance
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        [ForeignKey("HouseId")]
        public House? House { get; set; }
        public double TotalPaidAmount { get; set; }
        public double TotalPurchasedElectricity { get; set; }
        public double TotalConsumedElectricity { get; set; }
        public double RemainingElectricity { get; set; }
        public double CurrentConsumption { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}