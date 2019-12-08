using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class IsRegexMatch : SingleRule
    {
        public IsRegexMatch(string pattern):base("Chuỗi không khớp với mẫu đưa ra")
        {
            value = pattern;
        }
        public IsRegexMatch(string errorMessage, string pattern): base(errorMessage)
        {
            value = pattern;
        }
        protected override bool CheckValid(dynamic target)
        {
            Match result = Regex.Match(target, value);
            if (result.Length == target.Length) return true;
            else return false;
            
        }
    }
}
