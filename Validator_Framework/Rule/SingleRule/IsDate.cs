using System;

namespace Validation_Framework.Rule
{
    public class IsDate : SingleRule
    {
        public IsDate(string format) : this("Không phù hợp định dạng ngày", format)
        { }

        public IsDate(string errorMessage, string format) : base(errorMessage)
        {
            value = format;
        }

        protected override bool CheckValid(dynamic target)
        {
            DateTime result;
            dynamic check = DateTime.TryParseExact(target, value, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out result);
            return check;
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
