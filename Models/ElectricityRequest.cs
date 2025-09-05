using System.ComponentModel.DataAnnotations.Schema;

namespace smart_city_dotnetcore.Models
{
    public class ElectricityRequest
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        [ForeignKey("HouseId")]
        public House? House { get; set; }
        public double DeclaredAmount { get; set; }
        public RequestStatus Status { get; set; }
        public string Image { get; set; } = "";
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public enum RequestStatus {
        Pending,
        Approved,
        Rejected
    }
}