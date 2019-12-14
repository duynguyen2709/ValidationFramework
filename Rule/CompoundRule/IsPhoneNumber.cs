namespace Validation_Framework.Rule
{
    public class IsPhoneNumber : CompoundRule
    {
        public IsPhoneNumber() : this("Số điện thoại không hợp lệ")
        { }

        public IsPhoneNumber(string errorMessage) : base(errorMessage)
        {
            AddRule(new MinLength(10));
            AddRule(new MaxLength(10));
            AddRule(new StartWith("0"));
            AddRule(new IsNumber());
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
