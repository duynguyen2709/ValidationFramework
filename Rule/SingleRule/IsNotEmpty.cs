using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public class IsNotEmpty : SingleRule
    {
        public IsNotEmpty() : base("Chuỗi không rỗng")
        { }

        public IsNotEmpty(string message) : base(message)
        {
        }

        protected override bool CheckValid(dynamic target)
        {
            if (target is string)
            {
                if ((target as string).Length == 0 || target == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
