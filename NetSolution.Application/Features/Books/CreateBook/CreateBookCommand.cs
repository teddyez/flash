using MediatR;

namespace NetSolution.Application.Features.Books.CreateBook
{
    public class CreateBookCommand : IRequest<CreateBookResponse>
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Guid? AuthorId { get; set; }
    }
}