using EticaretApi.Application.Abstractions;
using EticaretApi.Application.DTOS;
using EticaretApi.Application.Exeptions;
using EticaretApi.Domain.Entities._Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._AppUser.LoginUser
{
    public class LoginUserCommendHandler : IRequestHandler<LoginUserCommendRequest, LoginUserCommendResponse>
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ITokenHandler tokenHandler;

        public LoginUserCommendHandler(UserManager<AppUser> userManager , SignInManager<AppUser> signInManager, ITokenHandler tokenHandler)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommendResponse> Handle(LoginUserCommendRequest request, CancellationToken cancellationToken)
        {
            var user = await userManager.FindByNameAsync(request.UserNameOrMailk);
            if (user==null)
            {
                user = await userManager.FindByEmailAsync(request.UserNameOrMailk);
            }
            if (user==null)
            {
                throw new Exception("Kullanıcı adı veya email hatalı...");
            }

           var result =await signInManager.CheckPasswordSignInAsync(user, request.Password,false);

            if (result.Succeeded) //Authentication basarılı
            {
                // .... Yetkılerı belırlememız gerekır
                Token token =tokenHandler.CreateAccessToken(5); //5 dk bı token 
                return new LoginUserSuccsessCommendResponse()
                {
                    Token = token
                };
            }
            //return new LoginUserErorsCommendResponse() {  //dogrusu alttakı fıkır versın dıye kalsın 
            // Message="Kullanıcı adı veya sıfre hataıdır ... "
            //};
            throw new AuthenticationErrorException();
        }
    }
}
