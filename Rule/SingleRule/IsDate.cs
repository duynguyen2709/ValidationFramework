using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    public class IsDate : SingleRule
    {
        public IsDate() : base("Không phải ngày")
        { }

        public IsDate(string errorMessage) : base(errorMessage)
        {

        }

        protected override bool CheckValid(dynamic target)
        {
            DateTime result;
            string[] formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy",
                    "dd/MM/yy", "dd/M/yy", "d/M/yy", "d/MM/yy"};
            var check = DateTime.TryParseExact(target,formats, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out result);
            return check;
        }
    }
}
