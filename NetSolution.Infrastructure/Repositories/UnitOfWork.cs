using NetSolution.Domain.Entities;
using NetSolution.Domain.Interfaces;
using NetSolution.Infrastructure.Persistence;

namespace NetSolution.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IRepository<User> _users;
        private readonly IRepository<Book> _books;
        private readonly IRepository<FlashCard> _flashCards;


        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            _users = new Repository<User>(_context);
            _books = new Repository<Book>(_context);
            _flashCards = new Repository<FlashCard>(_context);
        }

        public IRepository<User> Users => _users;
        public IRepository<Book> Books => _books;
        public IRepository<FlashCard> FlashCards => _flashCards;

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}