using FluentValidation;
using OrnekVebSitesi.Models.ViewModel;

namespace OrnekVebSitesi.Models.Validaters
{
    public class KullanıcıValidater:AbstractValidator<KullanıcıKaytViewModel>
    {
        public KullanıcıValidater()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("Gecerli mail giriniz");
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş geçilemez");

            RuleFor(x => x.İsimSoyiism).NotNull().WithMessage("Isım Soy ısım bos gecılemez");

            RuleFor(x => x.Şifere1).NotNull().WithMessage("Şifre bos gecılemez");
            
            RuleFor(x => x.Şifere2).Equal(i => i.Şifere1)
            .WithMessage("Şifreler eşleşmiyor.");

        }
    }
}
