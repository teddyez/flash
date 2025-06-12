using MediatR;
using NetSolution.Domain.Entities;
using NetSolution.Domain.Interfaces;

namespace NetSolution.Application.Features.Books.CreateBook
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, CreateBookResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateBookCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateBookResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                AuthorId = request.AuthorId
            };

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CommitAsync();

            return new CreateBookResponse
            {
                Id = book.Id,
                Name = book.Name,
                Description = book.Description,
                AuthorId = book.AuthorId
            };
        }
    }
}