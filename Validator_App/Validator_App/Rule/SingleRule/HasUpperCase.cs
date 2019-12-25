using System.Diagnostics;
using System.Linq;

namespace Validation_App.Rule
{
    public class HasUpperCase : SingleRule
    {
        public HasUpperCase() : this("Chuỗi phải chứa ít nhất 1 kí tự thường", 1)
        { }

        public HasUpperCase(string message, int n = 1) : base(message)
        {
            value = n;
        }
        protected override bool CheckValid(dynamic target)
        {
            int count = (target as string).Count(c => char.IsUpper(c));
            Trace.WriteLine("HasUpperCase: " + count);
            if (count < value)
                Trace.WriteLine("Error HasUpperCase");
            return (count >= value);
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
