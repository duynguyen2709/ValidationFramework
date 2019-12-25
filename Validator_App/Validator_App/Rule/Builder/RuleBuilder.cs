using System.Collections.Generic;
using Validation_App.Validator;

namespace Validation_App.Rule
{
    public class RuleBuilder
    {
        private List<AbstractRule> listRule;

        private RuleBuilder()
        {
            listRule = new List<AbstractRule>();
        }

        public static RuleBuilder Create()
        {
            return new RuleBuilder();
        }

        public RuleBuilder AddRule(AbstractRule rule)
        {
            listRule.Add(rule);
            return this;
        }

        public FieldValidator Build()
        {
            return new FieldValidator(listRule);
        }
    }
}
