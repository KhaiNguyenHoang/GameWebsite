using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Permission
    {
        public Permission() { }

        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        [RegularExpression(
            @"^[a-zA-Z0-9_]+$",
            ErrorMessage = "Only letters, numbers, and underscore allowed"
        )]
        public required string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }
        public virtual ICollection<Role>? Roles { get; set; }
        public virtual ICollection<Account>? Accounts { get; set; }
    }
}
