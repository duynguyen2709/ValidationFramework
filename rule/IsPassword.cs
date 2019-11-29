using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class IsPassword : CompoundRule
    {
        public IsPassword() : base("")
        {

        }
        public IsPassword(string errorMessage) : base(errorMessage)
        {
            this.AddRule(new MustBeLargerThan(6));
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
