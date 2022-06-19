using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori adını boş bırakmayınız.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Kategori açıklamasını boş bırakmayınız.");
            RuleFor(c => c.Name).MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olmalıdır.");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır..");
        }
    }
}
