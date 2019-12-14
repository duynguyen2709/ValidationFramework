using System;
using Validation_Framework.Result;

namespace Validation_Framework.Rule
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
            try
            {
                if (!CheckValid(target))
                {
                    validationResult = new ValidationResult(false, errorMessage);
                }
                else
                {
                    validationResult = new ValidationResult(true, "");
                }
            }
            catch (Exception e)
            {
                validationResult = new ValidationResult(false, e.Message);
            }

            return validationResult;
        }

        protected abstract bool CheckValid(dynamic target);
    }
}
