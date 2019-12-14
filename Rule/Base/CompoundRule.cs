using System.Collections.Generic;

namespace Validation_Framework.Rule
{
    public abstract class CompoundRule : AbstractRule
    {
        protected List<AbstractRule> listRule;

        protected CompoundRule(string errorMessage) : base(errorMessage)
        {
            listRule = new List<AbstractRule>();
        }

        protected void AddRule(AbstractRule rule)
        {
            listRule.Add(rule);
        }

        protected sealed override bool CheckValid(dynamic value)
        {
            foreach (AbstractRule abstractRule in listRule)
            {
                if (abstractRule.Validate(value).IsValid == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
