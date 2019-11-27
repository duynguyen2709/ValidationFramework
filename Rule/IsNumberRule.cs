using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoValidation.Rule
{
    class IsNumberRule : SingleRule
    {
        public IsNumberRule() : base("")
        {

        }
        public IsNumberRule(string errorMessage) : base(errorMessage)
        {

        }

        public override bool CheckValid(dynamic value)
        {
            return (value is int || value is long);
        }
    }
}
