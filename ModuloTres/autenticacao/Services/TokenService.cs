using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using autenticacao.Models;
using autenticacao.Security;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;

namespace autenticacao.Services
{
    public static class TokenService
    {
        //gera o token a partindo do usuario
        public static string GenerateTokenFromUser(User user)
        {
            var claims = new Claim[]
             {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, user.Role.GetDisplayName())
             };

            return GenerateTokenFromClaims(claims);
        }

        //classe utilizada para fornecer informações para o token
        // public static string GenerateToken(User user) para usar sem o refresh token
        public static string GenerateTokenFromClaims(IEnumerable<Claim> claims)
        {
            //o responsável pela criação do token
            var tokenHandler = new JwtSecurityTokenHandler();
            //transforma chave secreta em bytes
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            //congifuração do token
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                //informações adcionais
                //para usar sem o refresh token
                /* Subject = new ClaimsIdentity(new Claim[]
                {
                    
                     new Claim(ClaimTypes.Name, user.Email),
                    //get display puxa o nome da propriedade 
                    new Claim(ClaimTypes.Role, user.Role.GetDisplayName()),
                }), */

                Subject = new ClaimsIdentity(claims),
                //tempo de expiração
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            //cria o token
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        //método para recuperar o ClaimsPrincipal de um token expirado
        public static ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            //config/parameters do novo token 
            //parecido com o que está na program.cs
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Settings.Secret)),
                ValidateIssuer = false,
                ValidateAudience = false,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var secutiryToken);

            //valida se é um token do tipo jwt
            if (secutiryToken is not JwtSecurityToken jwtSecurityToken)
                throw new SecurityTokenException("Invalid token");

            return principal;
        }

        public static string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }

        //tupla de strings
        //como se fosse um dicionário
        //uma lista e combinação de duas strings
        private static List<Tuple<string, string>> _refreshsTokens = new List<Tuple<string, string>>();

        //crud para lidar com o refresh token
        public static void SaveRefreshToken(string username, string refreshToken)
            => _refreshsTokens.Add(new Tuple<string, string>(username, refreshToken));

        public static List<Tuple<string, string>> GetAllRefreshTokens()
                    => _refreshsTokens;

        public static string GetRefreshToken(string username)
            => _refreshsTokens.FirstOrDefault(x => x.Item1 == username).Item2;

        public static void DeleteRefreshToken(string username, string refreshToken)
        {
            var item = _refreshsTokens.FirstOrDefault(x => x.Item1 == username && x.Item2 == refreshToken);
            _refreshsTokens.Remove(item);
        }



    }
}