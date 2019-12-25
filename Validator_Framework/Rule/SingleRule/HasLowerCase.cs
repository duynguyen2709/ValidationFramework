using System.Linq;

namespace Validation_Framework.Rule
{
    public class HasLowerCase : SingleRule
    {
        public HasLowerCase() : this("Chuỗi phải chứa ít nhất 1 kí tự thường", 1)
        { }

        public HasLowerCase(string message, int n = 1) : base(message)
        {
            value = n;
        }
        protected override bool CheckValid(dynamic target)
        {
            int count = (target as string).Count(c => char.IsLower(c));
            return (count >= value);
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
