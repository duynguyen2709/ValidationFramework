using System;
using System.Collections.Generic;

namespace Validation_App.Rule
{
    public class IsNumber : SingleRule
    {
        public IsNumber() : this("Không phải số")
        { }

        public IsNumber(string errorMessage) : base(errorMessage)
        { }

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
                else
                {
                    if (c < '0' || c > '9' || Dotcount >= 2)
                        return false;
                }
            }

            return true;
        }

        protected override void AddSupportType()
        {
            List<Type> types = new List<Type>();
            types.AddRange(Utility.NumericTypes);
            types.AddRange(Utility.StringTypes);
            RuleContainer.GetInstance().AddSupportType(GetType(), types);
        }
    }
}
