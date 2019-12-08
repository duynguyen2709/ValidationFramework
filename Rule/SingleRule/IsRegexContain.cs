using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public class IsRegexContain : SingleRule
    {
        private Regex rg;
        public IsRegexContain(string pattern) : base("Chuỗi không khớp với mẫu đưa ra")
        {
            value = pattern;
            rg = new Regex(value);
        }
        public IsRegexContain(string errorMessage, string pattern) : base(errorMessage)
        {
            value = pattern;
            rg = new Regex(value);
        }
        protected override bool CheckValid(dynamic target)
        {
            MatchCollection matchCollection = rg.Matches(target);
            return matchCollection.Count > 0 ? true : false;
        }
    }
}
