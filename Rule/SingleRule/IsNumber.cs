namespace Validation_Framework.rule
{
    internal class IsNumber : SingleRule
    {
        public IsNumber() : base("Không phải số")
        { }

        public IsNumber(string errorMessage) : base(errorMessage)
        {

        }

        protected override bool CheckValid(dynamic target)
        {
            return (target is int || target is long || target is float || target is double);
        }
    }
}
