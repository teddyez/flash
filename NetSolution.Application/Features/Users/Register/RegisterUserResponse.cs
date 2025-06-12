namespace NetSolution.Application.Features.Users.Register
{
    public class RegisterUserResponse
    {
        public bool Success { get; set; }
        public string? UserId { get; set; }
        public string? ErrorMessage { get; set; }
    }
}