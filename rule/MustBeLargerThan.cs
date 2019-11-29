using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class MustBeLargerThan : SingleRule
    {
        public int N;

        public MustBeLargerThan(int n) : base("")
        {
            this.N = n;
        }

        public MustBeLargerThan(string message, int n) : base(message)
        {
            this.N = n;
        }
        public override bool CheckValid(dynamic value)
        {
            if (value is string)
            {
                if ((value as string).Length >= N)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
