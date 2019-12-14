using System.Collections.Generic;
using Validation_Framework.Result;
using Validation_Framework.Rule;

namespace Validation_Framework.Validator
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
