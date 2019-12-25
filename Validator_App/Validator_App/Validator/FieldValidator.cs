using System.Collections.Generic;
using Validation_App.Result;
using Validation_App.Rule;

namespace Validation_App.Validator
{
    public class FieldValidator : AbstractValidator
    {
        private readonly List<AbstractRule> listRule;

        public FieldValidator(List<AbstractRule> listRule) : base()
        {
            this.listRule = listRule;
        }

        public List<ValidationResult> Validate(dynamic value)
        {
            List<ValidationResult> ListResult = new List<ValidationResult>();

            foreach (AbstractRule rule in listRule)
            {
                ListResult.Add(rule.Validate(value));
            }

            return ListResult;
        }
    }
}
