using System.Collections.Generic;
using Validation_App.Result;

namespace Validation_App.Validator
{
    public interface AbstractValidator
    {
        List<ValidationResult> Validate(dynamic target);
    }
}
