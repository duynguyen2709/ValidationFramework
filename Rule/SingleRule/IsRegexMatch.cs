using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public class IsRegexMatch : SingleRule
    {
        private Regex rg;
        public IsRegexMatch(string pattern):base("Chuỗi không khớp với mẫu đưa ra")
        {
            value = pattern;
            rg = new Regex(value);
        }
        public IsRegexMatch(string errorMessage, string pattern): base(errorMessage)
        {
            value = pattern;
            rg = new Regex(value);
        }
        protected override bool CheckValid(dynamic target)
        {
            MatchCollection matchCollection = rg.Matches(target);
            foreach(Match child in matchCollection)
            {
                if (child.Length == (target as string).Length) return true;
            }
            return false;
            
        }
    }
}
