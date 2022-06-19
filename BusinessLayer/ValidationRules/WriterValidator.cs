using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen adınızı ve soyadınızı girin!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Adınız en az 3 karakter olmalıdır!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Lütfen şifreyi girin!");
        }
    }
}
