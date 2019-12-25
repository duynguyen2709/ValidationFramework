using System.Diagnostics;
using System.Linq;

namespace Validation_App.Rule
{
    public class HasNumber : SingleRule
    {
        public HasNumber() : this(string.Format("Chuỗi phải chứa ít nhất {0} số", 1))
        { }

        public HasNumber(string message, int n = 1) : base(message)
        {
            value = n;
        }
        protected override bool CheckValid(dynamic target)
        {
            int count = (target as string).Count(c => char.IsNumber(c));
            if (count < value)
                Trace.WriteLine("error HasNumber");
            return (count >= value);
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
