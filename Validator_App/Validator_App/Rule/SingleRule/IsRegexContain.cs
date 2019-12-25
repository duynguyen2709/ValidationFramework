using System.Text.RegularExpressions;

namespace Validation_App.Rule
{
    public class IsRegexContain : SingleRule
    {
        private Regex rg;

        public IsRegexContain(string pattern) : this("Chuỗi không khớp với mẫu đưa ra", pattern)
        { }

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

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
