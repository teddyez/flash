namespace NetSolution.Application.Features.Books.CreateBook
{
    public class CreateBookResponse
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Guid? AuthorId { get; set; }
    }
}