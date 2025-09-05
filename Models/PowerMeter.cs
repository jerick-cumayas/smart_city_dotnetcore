using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smart_city_dotnetcore.Models
{
    public class PowerMeter
    {
        [Key]
        public int Id{ get; set; }
        public int HouseId { get; set; }
        [ForeignKey("HouseId")]
        public House? House{ get; set; }
        public required string Name { get; set; }
        public required string EntityId { get; set; }
        public required string Type { get; set; }
        public required string Phase { get; set; }
        public required string Version { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime RemovedAt { get; set; }
    }
}