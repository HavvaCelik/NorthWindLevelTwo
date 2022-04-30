
using FluentValidation;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator:AbstractValidator<ShippingDetail>
    {
        public ShippingDetailValidator()
        {
            RuleFor(expression: s => s.FirstName).NotEmpty().WithMessage("Ad bilgisini giriniz");
            RuleFor(expression: s => s.FirstName).MinimumLength(2);
            RuleFor(expression: s => s.LastNAme).NotEmpty();

            //yaşı 18 den küçük ise şehri doldurması zorunlu
            RuleFor(expression: s => s.City).NotEmpty().When(s=>s.Age<18);

           // RuleFor(expression: s => s.FirstName).Must(StartWithA);

        }

        //gönderilen değer yani firstname
        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
