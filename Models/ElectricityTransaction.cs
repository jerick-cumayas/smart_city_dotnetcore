using System.ComponentModel.DataAnnotations.Schema;

namespace smart_city_dotnetcore.Models
{
    public class ElectricityTransaction
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        [ForeignKey("RequestId")]
        public ElectricityRequest? Request { get; set; }
        public int RateId { get; set; }
        [ForeignKey("RateId")]
        public ElectricityRate? Rate { get; set; }
        public int ApproverId { get; set; }
        [ForeignKey("ApproverId")]
        public AppUser? Approver { get; set; }
        public int RemarkId { get; set; }
        public TransactionRemark? Remark { get; set; }
        public double VerifiedAmount { get; set; }
        public double ElectricityAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}