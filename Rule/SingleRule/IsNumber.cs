namespace Validation_Framework.rule
{
    public class IsNumber : SingleRule
    {
        public IsNumber() : base("Không phải số")
        { }

        public IsNumber(string errorMessage) : base(errorMessage)
        {

        }

        protected override bool CheckValid(dynamic target)
        {
            if (target is int || target is long || target is float || target is double)
            {
                return true;
            }
            if (target == null || target == string.Empty)
                return false;
            int Dotcount = 0;
            foreach (char c in target)
            {
                if (c == '.' || c == ',')
                {
                    Dotcount++;
                }
                else {
                    if (c < '0' || c > '9' || Dotcount>=2 ) // Avoid using .IsDigit or .IsNumeric as they will return true for other characters
                    return false;
                }
            }

            return true;
        }
    }
}
