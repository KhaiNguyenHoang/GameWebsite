using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Account
    {
        public Account() { }

        public Account(
            Guid id,
            string username,
            string password,
            string nickname,
            string? avatar,
            string? bio,
            string? gender,
            DateTime? birthday,
            string? detailAddress,
            string? homeAddress,
            string phoneNumber,
            string email,
            IDCard idCard,
            bool isAdmin,
            bool isBanned,
            DateTime createdAt,
            DateTime updatedAt,
            DateTime? deletedAt
        )
        {
            Id = id;
            Username = username;
            Password = password;
            Nickname = nickname;
            Avatar = avatar;
            Bio = bio;
            Gender = gender;
            Birthday = birthday;
            DetailAddress = detailAddress;
            HomeAddress = homeAddress;
            PhoneNumber = phoneNumber;
            Email = email;
            IdCard = idCard;
            IsAdmin = isAdmin;
            IsBanned = isBanned;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeletedAt = deletedAt;
        }

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$")]
        [MinLength(6)]
        [MaxLength(20)]
        public required string Username { get; set; }

        [Required]
        [MinLength(8)]
        public required string Password { get; set; }

        [Required]
        public required string Salt { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(20)]
        public required string Nickname { get; set; }
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public required string? Gender { get; set; }

        [Required]
        [RegularExpression(@"^(0[1-9]|1[012])\/(0[1-9]|[12][0-9]|3[01])\/\d{4}$")]
        public required DateTime? Birthday { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_\-\.]+$")]
        [MinLength(6)]
        [MaxLength(20)]
        public required string? DetailAddress { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_\-\.]+$")]
        [MinLength(6)]
        [MaxLength(20)]
        public required string? HomeAddress { get; set; }

        [Required]
        [RegularExpression(@"^\d{11}$")]
        public required string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
        public required string Email { get; set; }

        public required IDCard IdCard { get; set; }

        [Required]
        public required bool IsAdmin { get; set; }

        [Required]
        public required bool IsBanned { get; set; }

        [Required]
        public required DateTime CreatedAt { get; set; }

        [Required]
        public required DateTime UpdatedAt { get; set; }
        public required DateTime? DeletedAt { get; set; }
    }
}
