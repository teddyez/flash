using MediatR;
using NetSolution.Application.Common;

namespace NetSolution.Application.Features.Users.Register
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, RegisterUserResponse>
    {
        private readonly Domain.Interfaces.IUnitOfWork _unitOfWork;

        public RegisterUserCommandHandler(Domain.Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RegisterUserResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var (passwordHash, passwordSalt) = PasswordUtil.HashPassword(request.Password);

            var user = new Domain.Entities.User
            {
                Username = request.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                InsertedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CommitAsync();

            return new RegisterUserResponse
            {
                Success = true,
                UserId = user.Id.ToString()
            };
        }
    }
}