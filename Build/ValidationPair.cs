using DemoValidation.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoValidation.Build
{
    class ValidationPair
    {
        readonly Func<dynamic, dynamic> func;
        readonly AbstractValidator validator;
        public ValidationPair(Func<dynamic, dynamic> func, AbstractValidator validator)
        {
            this.func = func;
            this.validator = validator;
        }

        public void Validate(dynamic value)
        {
            this.validator.Validate(func(value));
        }

        public List<ValidationResult> ValidateAndGetResult(dynamic value)
        {
            Validate(value);
            return this.validator.ListResult;
        }
    }
}
