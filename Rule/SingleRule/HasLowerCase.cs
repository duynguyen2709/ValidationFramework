using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public class HasLowerCase : SingleRule
    {

        public HasLowerCase() : base("Chuỗi phải chứa ít nhất 1 kí tự thường")
        {
            value = 1;
        }

        public HasLowerCase(string message, int n = 1) : base(message)
        {
            value = n;
        }
        protected override bool CheckValid(dynamic target)
        {
            int count = (target as string).Count(c => char.IsLower(c));
            return (count >= value);
        }
    }
}
