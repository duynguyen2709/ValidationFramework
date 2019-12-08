using System.Linq;

namespace Validation_Framework.rule
{
    class HasNumber : SingleRule
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
            if (count >= value) return true;
            else return false;
        }
    }
}
