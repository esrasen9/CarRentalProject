﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.Id).GreaterThan(0);
            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.CarId).GreaterThan(0);
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).GreaterThan(0);
            RuleFor(r => r.CustomerId).NotEmpty();
        }
    }
}
