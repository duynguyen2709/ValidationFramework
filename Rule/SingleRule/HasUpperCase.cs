using System.Linq;

namespace Validation_Framework.Rule
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
            return (count >= value);
        }
    }
}
