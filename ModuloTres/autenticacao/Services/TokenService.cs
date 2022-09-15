using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using autenticacao.Models;
using autenticacao.Security;
using Microsoft.IdentityModel.Tokens;

namespace autenticacao.Services
{
    public static class TokenService
    {
        //classe utilizada para fornecer informações para o token
        public static string GenerateToken(User user)
        {
            //o responsável pela criação do token
            var tokenHandler = new JwtSecurityTokenHandler();
            //transforma chave secreta em bytes
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            //congifuração do token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                //informações adcionais
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim(ClaimTypes.Role, user.Role),
                }),
                //tempo de expiração
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            //cria o token
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    }
}