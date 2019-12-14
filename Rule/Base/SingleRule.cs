namespace Validation_Framework.Rule
{
    public abstract class SingleRule : AbstractRule
    {
        protected dynamic value;

        protected SingleRule(string errorMessage) : base(errorMessage) { }

        protected SingleRule() : base() { }

        protected abstract override bool CheckValid(dynamic target);
    }
}
