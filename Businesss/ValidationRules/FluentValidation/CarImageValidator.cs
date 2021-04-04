using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c => c.CarImageId).NotEmpty();
            RuleFor(c => c.ImageDate).NotEmpty();
            RuleFor(c => c.ImagePath).NotEmpty();
        }
    }
}
