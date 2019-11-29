using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.result;
using Validation_Framework.rule;

namespace Validation_Framework.validator
{
    public class FieldValidator : AbstractValidator
    {
        readonly List<AbstractRule> listRule;

        public FieldValidator(List<AbstractRule> listRule) : base()
        {
            this.listRule = listRule;
        }

        public override List<ValidationResult> Validate(dynamic value)
        {
            listResult.Clear();
            foreach (AbstractRule rule in listRule)
            {
                listResult.Add(rule.Validate(value));
            }

            return listResult;
        }
    }
}
