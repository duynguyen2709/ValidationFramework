using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.result;

namespace Validation_Framework.rule
{
    public abstract class AbstractRule : Attribute
    {
        protected string errorMessage;

        public AbstractRule(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        public ValidationResult Validate(dynamic value)
        {
            ValidationResult validationResult = new ValidationResult();
            if (!CheckValid(value))
            {
                validationResult.ErrorMessage = this.errorMessage;
                validationResult.IsValid = false;
            }
            else
            {
                validationResult.IsValid = true;
            }
            return validationResult;
        }

        public abstract bool CheckValid(dynamic value);
    }
}
