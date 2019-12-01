using System;
using Validation_Framework.result;

namespace Validation_Framework.rule
{
    public abstract class AbstractRule : Attribute
    {
        protected string errorMessage;

        protected AbstractRule(string errorMessage)
        {
            this.errorMessage = errorMessage;
        }

        protected AbstractRule() { }

        public ValidationResult Validate(dynamic target)
        {
            ValidationResult validationResult;
            if (!CheckValid(target))
            {
                validationResult = new ValidationResult(false, errorMessage);
            }
            else
            {
                validationResult = new ValidationResult(true, "");
            }
            return validationResult;
        }

        protected abstract bool CheckValid(dynamic target);
    }
}
