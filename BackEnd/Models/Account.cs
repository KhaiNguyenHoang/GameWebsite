using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BackEnd.CustomValidations;

namespace BackEnd.Models
{
    public class Account
    {
        public Account() { }

        [Key]
        public int Id { get; set; }

        [Required, MinLength(6), MaxLength(20)]
        [RegularExpression(
            @"^[a-zA-Z0-9_]+$",
            ErrorMessage = "Only letters, numbers, and underscore allowed"
        )]
        public required string Username { get; set; }

        [Required]
        [MinLength(8)]
        public string PasswordHash { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? FullName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }

        // Foreign Key
        public int RoleId { get; set; }

        // Navigation Properties
        [ForeignKey("RoleId")]
        public virtual Role? Role { get; set; }

        // Relationships
        public virtual IDCard? IdCard { get; set; }
        public virtual ICollection<Role>? Roles { get; set; }
        public virtual ICollection<Permission>? Permissions { get; set; }
    }
}
