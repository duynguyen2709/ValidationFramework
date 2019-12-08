namespace Validation_Framework.rule
{
    public class MaxLength : SingleRule
    {
        public MaxLength(int n) : this(string.Format("Chuỗi phải chỉ được có tối đa {0} kí tự", n), n)
        { }

        public MaxLength(string message, int n) : base(message)
        {
            value = n;
        }

        protected override bool CheckValid(dynamic target)
        {
            if (target is string)
            {
                if ((target as string).Length <= value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
