using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using NetSolution.Domain.Entities;

namespace NetSolution.Application.Common
{
    public static class JwtTokenUtil
    {
        // For demo purposes only. In production, use configuration and secure storage.
        private const string SecretKey = "YourSuperSecretKeyForJwtTokenGeneration123!";
        private const string Issuer = "NetSolution";
        private const string Audience = "NetSolutionAudience";

        public static string GenerateAccessToken(User user, int expireMinutes = 30)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(SecretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(expireMinutes),
                Issuer = Issuer,
                Audience = Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static string GenerateRefreshToken()
        {
            // For demo: use a GUID. In production, use a cryptographically secure random string.
            return Guid.NewGuid().ToString("N");
        }
    }
}