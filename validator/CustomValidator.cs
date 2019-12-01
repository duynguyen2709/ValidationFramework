using System.Collections.Generic;
using Validation_Framework.result;

namespace Validation_Framework.validator
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
