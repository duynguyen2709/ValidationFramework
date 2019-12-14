using Validation_Framework.Rule;
using Validation_Framework.Validator;

namespace Validation_Framework.Demo
{
    internal class UserValidator : CustomValidator
    {
        public string Email;

        public int Age;

        public UserValidator(string email, int age)
        {
            Email = email;
            Age = age;
            Init();
        }

        protected override void Init()
        {
            SetValidator(nameof(Email), x => x.Email,
                                RuleBuilder.Create()
                                .AddRule(new IsEmail())
                                .Build());

            SetValidator(nameof(Age), x => x.Age,
                                RuleBuilder.Create()                                
                                .AddRule(new IsNumber())
                                .AddRule(new LargerThan(18))
                                .Build());
        }
    }
}
