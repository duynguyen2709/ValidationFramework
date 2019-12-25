namespace Validation_App.Rule
{
    public class IsNotEmpty : SingleRule
    {
        public IsNotEmpty() : this("Chuỗi không được rỗng")
        { }

        public IsNotEmpty(string message) : base(message)
        { }

        protected override bool CheckValid(dynamic target)
        {
            if (target is string)
            {
                if ((target as string).Length == 0 || target == null)
                {
                    return false;
                }
            }
            return true;
        }

        protected override void AddSupportType()
        {
            RuleContainer.GetInstance().AddSupportType(GetType(), Utility.StringTypes);
        }
    }
}
