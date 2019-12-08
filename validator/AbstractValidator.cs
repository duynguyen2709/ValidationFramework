using System.Collections.Generic;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    public abstract class AbstractValidator
    {
        public List<ValidationResult> ListResult { get; set; }

        public bool IsValid
        {
            get
            {
                foreach (ValidationResult result in ListResult)
                {
                    if (result.IsValid == false)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public AbstractValidator()
        {
            ListResult = new List<ValidationResult>();
        }

        public abstract List<ValidationResult> Validate(dynamic value);
    }
}
