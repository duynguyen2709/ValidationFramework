using System.Collections.Generic;
using Validation_Framework.Result;

namespace Validation_Framework.Validator
{
    internal class CustomValidator : ComponentValidator
    {
        public List<ValidationResult> Validate()
        {
            return Validate(this);
        }
        public List<ValidationResult> ValidateByPropertyName(string propertyName)
        {
            return ValidateByPropertyName(this, propertyName);
        }
    }
}
