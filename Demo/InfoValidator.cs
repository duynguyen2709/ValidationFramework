using Validation_Framework.Rule;
using Validation_Framework.Validator;

namespace Validation_Framework.Demo
{
    internal class InfoValidator : CustomValidator
    {
        public string Name;

        public int ID;

        public InfoValidator(string name, int id)
        {
            Name = name;
            ID = id;
            Init();
        }

        protected override void Init()
        {
            SetValidator(nameof(Name), x => x.Name,
                                RuleBuilder.Create()
                                .AddRule(new IsPassword("Khong phai password"))
                                .AddRule(new IsNumber())
                                .Build());

            SetValidator(nameof(ID), x => x.ID,
                                RuleBuilder.Create()
                                .AddRule(new IsPassword("Khong phai password Nha"))
                                .AddRule(new IsNumber())
                                .Build());
        }
    }
}
