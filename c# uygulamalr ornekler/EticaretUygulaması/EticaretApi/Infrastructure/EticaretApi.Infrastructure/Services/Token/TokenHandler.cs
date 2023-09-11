using EticaretApi.Application.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Infrastructure.Services.Token
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration configuration;

        public TokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public Application.DTOS.Token CreateAccessToken(int minute)
        {
            Application.DTOS.Token token = new();

            //Security keyın simetrıgını alıyoruz
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(configuration["Token:SecurityKey"]));

            //Şifrelenmiş kimliği oluşturuyotuz
            SigningCredentials signingCredentials = new(securityKey,SecurityAlgorithms.HmacSha256);

            //Olusturulacak token ayarlarını verıyotuz
            token.Expiration=DateTime.UtcNow.AddMinutes(minute); //bu sure kadar erısıle bılır olsun dedık 
            JwtSecurityToken jwtSecurityToken = new(
                 audience: configuration["Token:Audience"],
                  issuer: configuration["Token:Issuer"], 
                  expires:token.Expiration, //acık kalcagı sure 
                  notBefore:DateTime.UtcNow,  //üretilir üretilmez devereye gırsın dedık 
                  signingCredentials:signingCredentials  //ustekı sıfrelenmıs bılgıler gelcek
                );
            //Token olusturucu sınıfından bır ornek alalım 
            JwtSecurityTokenHandler jwtSecurityTokenHandler=new();
            token.AccessToken = jwtSecurityTokenHandler.WriteToken(jwtSecurityToken);
            return token;
        }
    }
}
