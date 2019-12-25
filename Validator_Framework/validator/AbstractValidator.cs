using System.Collections.Generic;
using Validation_Framework.Result;

namespace Validation_Framework.Validator
{
    public interface AbstractValidator
    {       
        List<ValidationResult> Validate(dynamic target);
    }
}
