using System.Collections.Generic;
using Validation_Framework.result;

namespace Validation_Framework.Validator
{
    public interface IValidator
    {
        List<ValidationResult> Validate(dynamic value);
    }
}
