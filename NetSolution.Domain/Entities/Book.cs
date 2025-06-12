using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSolution.Domain.Entities;

[Table("Books")]
public class Book : BaseEntity
{
    [Key]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public Guid? AuthorId { get; set; }
    public User? Author { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public ICollection<FlashCard> FlashCards { get; set; } = new List<FlashCard>();
}