using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2).WithMessage("Araba model adı en az 2 karakter uzunluğunda olmalıdır.");

            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Fiyatı 0 TL'den büyük olmalıdır.");
            RuleFor(c => c.DailyPrice).NotEmpty();

            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2).WithMessage("Arabayı temel olarak tanımlayan özelliği en az 2 karakter uzunluğunda olmalıdır.");

            RuleFor(c => c.ModelYear).NotEmpty();

            RuleFor(c => c.BrandId).NotEmpty();

            RuleFor(c => c.ColorId).NotEmpty();
        }
    }
}
