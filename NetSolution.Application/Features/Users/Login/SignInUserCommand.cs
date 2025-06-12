using MediatR;

namespace NetSolution.Application.Features.Users.Login
{
    public class SignInUserCommand : IRequest<SignInUserResponse>
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}