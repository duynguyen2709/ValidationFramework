using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoValidation.Result;

namespace DemoValidation.Rule
{
    class IsPasswordRule : CompoundRule
    {
        public IsPasswordRule() : base("")
        {

        }
        public IsPasswordRule(string errorMessage) : base(errorMessage)
        {
            this.AddRule(new IsNumberRule());
            this.AddRule(new IsNumberRule());
        }

        public override bool CheckValid(dynamic value)
        {
            bool result = true;

            foreach (AbstractRule abstractRule in listRule)
            {
                if (abstractRule.Validate(value).IsValid == false) result = false;
            }
            return result;
        }
    }
}
