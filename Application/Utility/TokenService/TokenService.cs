using Domain.entity.Model.Party;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Utility.TokenService
{
    public interface ITokenService
    {
        TokenResult CreateTokens(User user);
    }
    public class TokenServises : ITokenService
    {
        public TokenResult CreateTokens(User user)
        {
            // کلید محرمانه
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ie@kykKEcgyWpZaoQl50N*q!c6Hp#9b!9fM6DrzPU@CX7w3jq"));

            // کلایم‌ها برای Access Token
            var claims = new List<Claim>
    {
        new(JwtRegisteredClaimNames.NameId, user.Id.ToString()),
        new(JwtRegisteredClaimNames.Sid , user.PhoneNumber),
    };

            // Credentials
            var creds = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            // توکن دسترسی (Access Token)
            var accessTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(15), // زمان انقضای Access Token
                SigningCredentials = creds
            };

            // ایجاد Access Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var accessToken = tokenHandler.CreateToken(accessTokenDescriptor);

            // ایجاد Refresh Token
            var refreshToken = new RefreshToken
            {
                Token = Convert.ToBase64String(Guid.NewGuid().ToByteArray()),
                Expires = DateTime.UtcNow.AddDays(30) // زمان انقضای Refresh Token (مثلاً 30 روز)
            };


            // بازگرداندن Access Token و Refresh Token
            return new TokenResult
            {
                AccessToken = tokenHandler.WriteToken(accessToken),
                RefreshToken = refreshToken.Token // فقط توکن را برمی‌گردانیم
            };
        }


    }
    public class TokenResult
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
    public class RefreshToken
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public bool IsActive => !IsExpired;
    }

}


