using Blog.EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.ValidationRules.CategoryValidation
{
    internal class UpdateCategoryValidation:AbstractValidator<Category>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adını boş geçmeyiniz").MaximumLength(3).WithMessage("Kategori Adını En az 3 karekter giriniz").MaximumLength(30).WithMessage("Lütfen kategori adını en fazla 30 karekter olarak giriniz.").Equal("a").WithMessage("lütfen kategori adına a harfi ekleyiniz"); 
        }
    }
}
