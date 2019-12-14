namespace Validation_Framework.Rule
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
            if (target is string)
            {
                if ((target as string).Length >= value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
