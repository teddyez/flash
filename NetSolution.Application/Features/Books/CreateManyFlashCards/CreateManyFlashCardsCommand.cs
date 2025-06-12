using MediatR;
using NetSolution.Application.DTOs;

namespace NetSolution.Application.Features.Books.CreateManyFlashCards
{
    public class CreateManyFlashCardsCommand : IRequest<CreateManyFlashCardsResponse>
    {
        public Guid BookId { get; set; }
        public List<FlashCardDto> FlashCards { get; set; }
    }
}