namespace Validation_Framework.Rule
{
    public class LargerThan : SingleRule
    {
        public LargerThan(int n) : this(string.Format("Giá trị phải lớn hơn {0}", n), n)
        { }

        public LargerThan(string message, int n) : base(message)
        {
            value = n;
        }

        protected override bool CheckValid(dynamic target)
        {
            return (target > value);
        }
    }
}
