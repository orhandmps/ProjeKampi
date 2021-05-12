using Entity.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
   public class CategoryValidatior: AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezisniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Maximum 20 karakter girişi yapabilirsiniz");
        }
    }
}
