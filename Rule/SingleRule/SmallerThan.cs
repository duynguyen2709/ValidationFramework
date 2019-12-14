namespace Validation_Framework.Rule
{
    public class SmallerThan : SingleRule
    {
        public SmallerThan(int n) : this(string.Format("Giá phải nhỏ hơn {0}", n), n)
        { }

        public SmallerThan(string message, int n) : base(message)
        {
            value = n;
        }

        protected override bool CheckValid(dynamic target)
        {
            return (target < value);
        }
    }
}
