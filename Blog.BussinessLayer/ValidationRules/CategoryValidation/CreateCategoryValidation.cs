using Blog.EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.ValidationRules.CategoryValidation
{
  public class CreateCategoryValidation:AbstractValidator<Category>
    {
        public CreateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adı En az 3 karekter Olması gerekir.");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Kategori Adını fazla 50 karekter olarak giriniz");
        }
    }
}
