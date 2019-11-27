using DemoValidation.Build;
using DemoValidation.Result;

namespace DemoValidation.Rule
{
    public abstract class AbstractRule
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