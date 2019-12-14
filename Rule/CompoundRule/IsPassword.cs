namespace Validation_Framework.Rule
{
    public class IsPassword : CompoundRule
    {
        public IsPassword() : this("Không phù hợp định dạng mật khẩu")
        {}

        public IsPassword(string errorMessage) : base(errorMessage)
        {
            AddRule(new MinLength(8));
            AddRule(new HasUpperCase());
            AddRule(new HasNumber());
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
