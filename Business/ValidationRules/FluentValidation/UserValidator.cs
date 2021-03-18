using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id).GreaterThan(0);
            RuleFor(u => u.FirstName.Length).GreaterThan(0);
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Password.Length).GreaterThan(6);
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password.Length).LessThanOrEqualTo(12);
            RuleFor(u => u.Email).EmailAddress();
        }
    }
}
