using System.Linq;

namespace Validation_Framework.rule
{
    public class HasNumber : SingleRule
    {

        public HasNumber() : base("Chuỗi phải chứa số")
        {
            value = 1;
        }

        public HasNumber(string message, int n = 1) : base(message)
        {
            value = n;
        }
        protected override bool CheckValid(dynamic target)
        {
            int count = (target as string).Count(c => char.IsNumber(c));
            return (count >= value);
        }
    }
}
