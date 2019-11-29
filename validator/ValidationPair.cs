using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    class ValidationPair
    {
        readonly Func<dynamic, dynamic> func;
        readonly FieldValidator validator;

        public ValidationPair(Func<dynamic, dynamic> func, FieldValidator validator)
        {
            this.func = func;
            this.validator = validator;
        }

        public void Validate(dynamic value)
        {
            this.validator.ListResult.Clear();
            this.validator.Validate(func(value));
        }

        public List<ValidationResult> ValidateAndGetResult(dynamic value)
        {
            Validate(value);
            return this.validator.ListResult;
        }
    }
}
