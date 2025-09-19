namespace BackEnd.Models
{
    public class SecretKey
    {
        public SecretKey() { }

        public Guid Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string? Description { get; set; }
        public Account Account { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime ExpireAt { get; set; }
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Account>? Accounts { get; set; }
        public virtual ICollection<Role>? Roles { get; set; }
        public virtual ICollection<Permission>? Permissions { get; set; }
    }
}
