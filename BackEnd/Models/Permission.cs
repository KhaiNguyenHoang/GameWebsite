using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class Permission
{
    public Permission() { }

    public Permission(
        Guid id,
        string name,
        string? description,
        DateTime createdAt,
        DateTime updatedAt,
        DateTime? deletedAt
    )
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; set; }

    [Required(ErrorMessage = "Permission name is required")]
    [RegularExpression(@"^[a-zA-Z0-9_]+$")]
    public required string Name { get; set; }
}
