using FluentValidation;
using OrnekVebSitesi.Models.ViewModel;

namespace OrnekVebSitesi.Models.Validaters
{
    public class KullanıcıGirişValşidater:AbstractValidator<KullaniciGirişiViewModel>
    {
        public KullanıcıGirişValşidater()
        {
            RuleFor(x => x.Mail).EmailAddress().WithMessage("Gecerli mail giriniz");
            RuleFor(x => x.Mail).NotNull().WithMessage("Email boş geçilemez");

            RuleFor(x => x.Şifre).NotNull().WithMessage("Şifre bos gecılemez");
            
        }
    }
}
