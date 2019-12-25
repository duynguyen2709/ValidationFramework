using System.Diagnostics;

namespace Validation_App.Rule
{
    public class MinLength : SingleRule
    {
        public MinLength(int n) : this(string.Format("Chuỗi phải dài hơn {0} kí tự", n), n)
        { }

        public MinLength(string message, int n) : base(message)
        {
            value = n;
        }

        protected override bool CheckValid(dynamic target)
        {
            Trace.WriteLine("Target string in MinLength: " + (target as string));
            if (target is string)
            {
                if ((target as string).Length >= value)
                {
                    return true;
                }
            }
            Trace.WriteLine("Error MinLength");
            return false;
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
