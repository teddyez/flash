using System;
using System.ComponentModel.DataAnnotations;

namespace NetSolution.Domain.Entities
{
    public class FlashCard : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }

        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}