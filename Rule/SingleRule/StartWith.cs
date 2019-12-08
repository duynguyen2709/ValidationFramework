using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.rule
{
    class StartWith : SingleRule
    {
        public StartWith(string input) : base("Chuỗi phải bắt đầu bằng kí tự" + input)
        {
            value = input;
        }
        public StartWith(string errorMessage, string input) : base(errorMessage)
        {
            value = input;
        }
        protected override bool CheckValid(dynamic target)
        {
            if (target[0] == value[0]) return true;
            else return false;
        }
    }
}