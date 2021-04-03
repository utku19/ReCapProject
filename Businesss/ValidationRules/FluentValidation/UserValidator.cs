using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesss.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz.");
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("Kullanıcı adı en az 2 karakter uzunluğunda olmalıdır.");

            RuleFor(u => u.LastName).NotEmpty().WithMessage("Kullanıcı soyadı boş bırakılamaz.");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Kullanıcı soyadı en az 2 karakter uzunluğunda olmalıdır.");

            RuleFor(u => u.Email).NotEmpty().WithMessage("Kullanıcı email adresi boş bırakılamaz.");

        }
    }
}
