using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    class CustomValidator : ComponentValidator
    {
        public List<ValidationResult> Validate()
        {
            return this.Validate(this);
        }
        public List<ValidationResult> ValidateByName(string nameProperty)
        {
            return ValidateByName(this, nameProperty);
        }

        public bool CheckValid()
        {
            return IsValid();
        }

        public bool CheckValidByName(string nameProperty)
        {
            this.ValidateByName(this, nameProperty);
            return IsValid();
        }
    }
}
