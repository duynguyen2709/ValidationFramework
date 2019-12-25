namespace Validation_Framework.Rule
{
    public class Equal : SingleRule
    {
        public Equal(int n) : this(string.Format("Giá trị phải bằng {0}", n), n)
        { }

        public Equal(string message, int n) : base(message)
        {
            value = n;
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.NumericTypes);
        }

        protected override bool CheckValid(dynamic target)
        {
            return (target == value);
        }
    }
}
