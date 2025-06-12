using MediatR;
using NetSolution.Application.Common;
using NetSolution.Domain.Interfaces;

namespace NetSolution.Application.Features.Users.Login
{
    public class SignInUserCommandHandler : IRequestHandler<SignInUserCommand, SignInUserResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public SignInUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<SignInUserResponse> Handle(SignInUserCommand request, CancellationToken cancellationToken)
        {
            var users = await _unitOfWork.Users.GetAllAsync();
            var user = users.FirstOrDefault(u => u.Username == request.UserName);

            if (user == null || user.PasswordHash == null || user.PasswordSalt == null)
            {
                return new SignInUserResponse { Success = false, ErrorMessage = "Invalid credentials." };
            }

            if (!PasswordUtil.VerifyPassword(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return new SignInUserResponse { Success = false, ErrorMessage = "Invalid credentials." };
            }

            var accessToken = JwtTokenUtil.GenerateAccessToken(user);
            var refreshToken = JwtTokenUtil.GenerateRefreshToken();

            return new SignInUserResponse
            {
                Success = true,
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }
    }
}