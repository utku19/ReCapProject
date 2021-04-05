using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).LessThan(r => r.ReturnDate);
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.RentDate);
        }
    }
}
