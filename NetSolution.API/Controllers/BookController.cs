using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetSolution.Application.Features.Books.CreateBook;
using NetSolution.Application.Features.Books.CreateManyFlashCards;
using System.Threading.Tasks;

namespace NetSolution.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(CreateBook), new { id = result.Id }, result);
        }

        [HttpPost("{bookId}/flashcards")]
        public async Task<IActionResult> CreateManyFlashCards([FromRoute] Guid bookId, [FromBody] CreateManyFlashCardsCommand command)
        {
            if (command == null) return BadRequest();
            command.BookId = bookId;
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}