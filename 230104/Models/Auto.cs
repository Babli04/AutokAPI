using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _230104.Models
{
    public class Auto
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Márka { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Típus { get; set; }

        public DateTime CreatedTime { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
