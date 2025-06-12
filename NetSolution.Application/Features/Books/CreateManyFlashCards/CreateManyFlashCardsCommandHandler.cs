using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using NetSolution.Domain.Entities;
using NetSolution.Domain.Interfaces;

namespace NetSolution.Application.Features.Books.CreateManyFlashCards
{
    public class CreateManyFlashCardsCommandHandler : IRequestHandler<CreateManyFlashCardsCommand, CreateManyFlashCardsResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateManyFlashCardsCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CreateManyFlashCardsResponse> Handle(CreateManyFlashCardsCommand request, CancellationToken cancellationToken)
        {
            var flashCardIds = new List<Guid>();

            foreach (var dto in request.FlashCards)
            {
                var flashCard = new FlashCard
                {
                    Id = Guid.NewGuid(),
                    Title = dto.Title,
                    Description = dto.Description,
                    BookId = request.BookId
                };

                await _unitOfWork.FlashCards.AddAsync(flashCard);
                flashCardIds.Add(flashCard.Id);
            }

            await _unitOfWork.CommitAsync();

            return new CreateManyFlashCardsResponse
            {
                FlashCardIds = flashCardIds
            };
        }
    }
}