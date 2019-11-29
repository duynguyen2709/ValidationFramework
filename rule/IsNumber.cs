using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class IsNumber : SingleRule
    {
        public IsNumber() : base("")
        {

        }
        public IsNumber(string errorMessage) : base(errorMessage)
        {

        }

        public override bool CheckValid(dynamic value)
        {
            return (value is int || value is long);
        }
    }
}
