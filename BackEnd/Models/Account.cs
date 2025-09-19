using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Account
    {
        public Account() { }

        [Key]
        public Guid Id { get; set; }

        [Required, MinLength(6), MaxLength(20)]
        [RegularExpression(
            @"^[a-zA-Z0-9_]+$",
            ErrorMessage = "Only letters, numbers, and underscore allowed"
        )]
        public required string Username { get; set; }

        [Required, MinLength(8)]
        public required string Password { get; set; }

        [Required]
        public required string Salt { get; set; }

        [Required, MinLength(6), MaxLength(50)]
        public required string Nickname { get; set; }

        [MaxLength(255)]
        public string? Avatar { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [MaxLength(20)]
        public string? Gender { get; set; }

        public DateTime? Birthday { get; set; }

        [MaxLength(255)]
        public string? DetailAddress { get; set; }

        [MaxLength(255)]
        public string? HomeAddress { get; set; }

        [Required, RegularExpression(@"^\d{10,11}$")]
        public required string PhoneNumber { get; set; }

        [Required, EmailAddress]
        public required string Email { get; set; }

        public bool IsAdmin { get; set; } = false;
        public bool IsBanned { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }

        // Quan hệ
        public virtual IDCard? IdCard { get; set; }
        public virtual ICollection<Role>? Roles { get; set; }
        public virtual ICollection<Permission>? Permissions { get; set; }
    }
}
