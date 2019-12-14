using System.Text.RegularExpressions;

namespace Validation_Framework.Rule
{
    public class IsRegexMatch : SingleRule
    {
        private Regex rg;

        public IsRegexMatch(string pattern) : this("Chuỗi không khớp với mẫu đưa ra", pattern)
        { }

        public IsRegexMatch(string errorMessage, string pattern) : base(errorMessage)
        {
            value = pattern;
            rg = new Regex(value);
        }

        protected override bool CheckValid(dynamic target)
        {
            MatchCollection matchCollection = rg.Matches(target);
            foreach (Match child in matchCollection)
            {
                if (child.Length == (target as string).Length)
                {
                    return true;
                }
            }
            return false;
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
