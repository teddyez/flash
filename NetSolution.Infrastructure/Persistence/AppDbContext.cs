using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetSolution.Domain.Entities;

namespace NetSolution.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<FlashCard> FlashCards { get; set; }
    }
}