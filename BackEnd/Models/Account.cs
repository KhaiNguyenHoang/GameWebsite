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
            string? birthday,
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

        public Guid Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Nickname { get; set; }
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public required string? Gender { get; set; }
        public required string? Birthday { get; set; }
        public required string? DetailAddress { get; set; }
        public required string? HomeAddress { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Email { get; set; }
        public required IDCard IdCard { get; set; }
        public required bool IsAdmin { get; set; }
        public required bool IsBanned { get; set; }
        public required DateTime CreatedAt { get; set; }
        public required DateTime UpdatedAt { get; set; }
        public required DateTime? DeletedAt { get; set; }
    }
}
