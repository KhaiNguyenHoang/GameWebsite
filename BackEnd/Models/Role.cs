using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Role
    {
        public Role() { }

        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(50)]
        public required string Name { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public virtual ICollection<Account>? Accounts { get; set; }
    }
}
