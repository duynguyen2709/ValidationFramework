using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    public abstract class AbstractValidator
    {
        protected List<ValidationResult> listResult;
        public List<ValidationResult> ListResult { get => listResult; set => listResult = value; }


        public AbstractValidator()
        {
            listResult = new List<ValidationResult>();
        }

        public abstract List<ValidationResult> Validate(dynamic value);

        protected bool IsValid()
        {
            foreach (ValidationResult result in listResult)
            {
                if (result.IsValid == false) return false;
            }
            return true;
        }
    }
}
