using System;
using System.Collections.Generic;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    public class ValidationPair
    {
        private readonly Func<dynamic, dynamic> func;
        private readonly FieldValidator validator;

        public ValidationPair(Func<dynamic, dynamic> func, FieldValidator validator)
        {
            this.func = func;
            this.validator = validator;
        }

        public void Validate(dynamic value)
        {
            validator.ListResult.Clear();
            this.validator.Validate(func(value));
        }

        public List<ValidationResult> ValidateAndGetResult(dynamic target)
        {
            Validate(target);
            return validator.ListResult;
        }
    }
}
