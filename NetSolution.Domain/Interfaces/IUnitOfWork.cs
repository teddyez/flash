using System.Threading.Tasks;

namespace NetSolution.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<NetSolution.Domain.Entities.User> Users { get; }
        IRepository<NetSolution.Domain.Entities.Book> Books { get; }
        IRepository<NetSolution.Domain.Entities.FlashCard> FlashCards { get; }
        Task<int> CommitAsync();
    }
}