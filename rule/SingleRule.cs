using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public abstract class SingleRule : AbstractRule
    {
        protected dynamic value;
        public SingleRule(string errorMessage) : base(errorMessage)
        {
        }

        public override bool CheckValid(dynamic value)
        {
            return true;
        }
    }
}
