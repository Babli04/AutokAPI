using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _230104.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? UserName { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? UserEmail { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string? Password { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
