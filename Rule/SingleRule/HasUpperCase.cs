using System.Linq;

namespace Validation_Framework.rule
{
    public class HasUpperCase : SingleRule
    {

        public HasUpperCase() : base("Chuỗi phải chứa ít nhất 1 kí tự hoa")
        {
            value = 1;
        }

        public HasUpperCase(string message, int n = 1) : base(message)
        {
            value = n;
        }
        protected override bool CheckValid(dynamic target)
        {
            int count = (target as string).Count(c => char.IsUpper(c));
            return (count >= value);
        }
    }
}
