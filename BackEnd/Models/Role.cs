namespace BackEnd.Models;

public class Role
{
    public Role() { }

    public Role(int id, string name, string? description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string? Description { get; set; }
}
