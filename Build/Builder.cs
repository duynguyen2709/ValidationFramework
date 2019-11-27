using DemoValidation.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoValidation.Build
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
