using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class CompoundRule : AbstractRule
    {
        protected List<AbstractRule> listRule;

        public CompoundRule(string errorMessage) : base(errorMessage)
        {
            listRule = new List<AbstractRule>();
        }

        protected void AddRule(AbstractRule rule)
        {
            listRule.Add(rule);
        }

        public override bool CheckValid(dynamic value)
        {
            return true;
        }
    }
}
