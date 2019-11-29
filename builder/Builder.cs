using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.rule;
using Validation_Framework.validator;

namespace Validation_Framework.builder
{
    public class Builder
    {
        private readonly List<AbstractRule> listRule;

        private Builder()
        {
            listRule = new List<AbstractRule>();
        }

        public static Builder Create()
        {
            return new Builder();
        }

        public Builder AddRule(AbstractRule rule)
        {
            this.listRule.Add(rule);
            return this;
        }

        public FieldValidator Build()
        {
            return new FieldValidator(listRule);
        }
    }
}
