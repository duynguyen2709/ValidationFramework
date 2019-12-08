using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public class IsPhoneNumber :CompoundRule
    {
        public IsPhoneNumber() : this("Số điện thoại không hợp lệ")
        {
            AddRule(new MinLength(10));
            AddRule(new MaxLength(10));
            AddRule(new StartWith("0"));
            AddRule(new IsNumber());
        }

        public IsPhoneNumber(string errorMessage) : base(errorMessage)
        {
            AddRule(new MinLength(10));
            AddRule(new MaxLength(10));
            AddRule(new StartWith("0"));
            AddRule(new IsNumber());
        }
    }
}
