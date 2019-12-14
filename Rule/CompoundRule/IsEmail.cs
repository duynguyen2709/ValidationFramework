namespace Validation_Framework.Rule
{
    public class IsEmail : CompoundRule
    {
        public IsEmail() : this("Không phù hợp định dạng email")
        { }

        public IsEmail(string errorMessage) : base(errorMessage)
        {
            AddRule(new IsRegexMatch(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"));
        }

    }
}
