using DemoValidation.Rule;
using System.Collections.Generic;

namespace DemoValidation.Build
{
    public class FieldValidator : AbstractValidator
    {
        readonly List<AbstractRule> listRule;

        public FieldValidator(List<AbstractRule> listRule): base()
        {
            this.listRule = listRule;
        }

        public override void Validate(dynamic value)
        {
            foreach (AbstractRule rule in listRule)
            {
                ListResult.Add(rule.Validate(value));
            }
        }
    }
}