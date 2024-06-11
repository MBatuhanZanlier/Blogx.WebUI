using Blog.EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.ValidationRules.ArticleValidation
{
   public  class CreateArticleValidation:AbstractValidator<Article>
    {
        public CreateArticleValidation()
        {
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Lütfen makale için bir kategori seçiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen makale için bir başlık giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen makale için açıklama giriniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("lütfen başlık giriniz");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Lütfen başlığı en fazla 100 karekter veri girişi yapınız");
        }
    }
}
