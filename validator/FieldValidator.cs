using System.Collections.Generic;
using Validation_Framework.result;
using Validation_Framework.rule;

namespace Validation_Framework.validator
{
    public class FieldValidator : AbstractValidator
    {
        private readonly List<AbstractRule> listRule;

        public FieldValidator(List<AbstractRule> listRule) : base()
        {
            this.listRule = listRule;
        }

        public override List<ValidationResult> Validate(dynamic value)
        {
            ListResult.Clear();
            foreach (AbstractRule rule in listRule)
            {
                ListResult.Add(rule.Validate(value));
            }

            return ListResult;
        }
    }
}
