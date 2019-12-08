using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class IsRegexContain : SingleRule
    {
        public IsRegexContain(string pattern) : base("Chuỗi không khớp với mẫu đưa ra")
        {
            value = pattern;
        }
        public IsRegexContain(string errorMessage, string pattern) : base(errorMessage)
        {
            value = pattern;
        }
        protected override bool CheckValid(dynamic target)
        {
            return Regex.IsMatch(target, value);
        }
    }
}
