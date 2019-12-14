namespace Validation_Framework.Rule
{
    public class StartWith : SingleRule
    {
        public StartWith(string input) : this(string.Format("Chuỗi phải bắt đầu bằng kí tự {0}", input), input)
        { }

        public StartWith(string errorMessage, string input) : base(errorMessage)
        {
            value = input;
        }

        protected override bool CheckValid(dynamic target)
        {
            return (target[0] == value[0]);
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}