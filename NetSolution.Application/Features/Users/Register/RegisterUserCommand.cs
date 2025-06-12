using MediatR;

namespace NetSolution.Application.Features.Users.Register
{
    public class RegisterUserCommand : IRequest<RegisterUserResponse>
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
    }
}