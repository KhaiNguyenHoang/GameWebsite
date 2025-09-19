using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class IDCard
    {
        public IDCard() { }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [ForeignKey(nameof(AccountId))]
        public virtual Account? Account { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        [Required, MaxLength(100)]
        public required string Name { get; set; }

        [Required, MaxLength(10)]
        public required string Sex { get; set; }

        [Required, MaxLength(255)]
        public required string Address { get; set; }

        [Required, MaxLength(50)]
        public required string Nationality { get; set; }

        [Required, MaxLength(20)]
        public required string IdNumber { get; set; }

        [Required]
        public DateTime Birthday { get; set; }
    }
}
