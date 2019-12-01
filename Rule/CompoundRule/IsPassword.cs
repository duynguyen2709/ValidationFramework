namespace Validation_Framework.rule
{
    public class IsPassword : CompoundRule
    {
        public IsPassword() : this("Không phù hợp định dạng mật khẩu")
        {}

        public IsPassword(string errorMessage) : base(errorMessage)
        {
            AddRule(new MinLength(6));
            // more rules here
        }
    }
}
