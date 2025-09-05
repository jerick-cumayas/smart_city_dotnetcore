using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smart_city_dotnetcore.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public required string IdentiyId { get; set; }
        [ForeignKey("UserId")]
        public Identity? Identity { get; set; }
        public required string FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Image { get; set; } = "";
    }
    public enum Gender {
        Male,
        Female
    }
}