using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSolution.Domain.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public required string Username { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}