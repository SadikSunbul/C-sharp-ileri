using EticaretApi.Application.Exeptions;
using EticaretApi.Domain.Entities._Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretApi.Application.Features.Commends._AppUser.CreateUser
{
    public class CreateUserCommendHandler : IRequestHandler<CreateUserCommendRequest, CreateUserCommendResponse>
    {
        private readonly UserManager<AppUser> userManager; //ıoc den talep ettık

        public CreateUserCommendHandler(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<CreateUserCommendResponse> Handle(CreateUserCommendRequest request, CancellationToken cancellationToken)
        {
           IdentityResult result=await userManager.CreateAsync(new AppUser {
             Id=Guid.NewGuid().ToString(),
             UserName = request.UserName,
             Email = request.Email,
             NamwSurnaem=request.NameSurname
            },request.Password); //request.Password bunu dısarda vermemzın seyı sıfremelesı

            CreateUserCommendResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
            {
                response.Message = "Kullanıcıc basarılı bısekılde kayıtoldu";            }
            else
            {
                foreach (var item in result.Errors)
                {
                    response.Message += $"{item.Code} - {item.Description}\n";
                }
            }
            return response;
        }
    }
}
