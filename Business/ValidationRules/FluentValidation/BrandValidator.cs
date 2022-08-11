﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
            RuleFor(c => c.BrandName).NotEmpty();
            RuleFor(c => c.BrandName).MinimumLength(3);
        }
    }
}
