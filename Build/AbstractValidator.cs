using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoValidation.Result;

namespace DemoValidation.Build
{
    public abstract class AbstractValidator
    {
        private List<ValidationResult> listResult;

        public List<ValidationResult> ListResult { get => listResult; set => listResult = value; }

        public AbstractValidator()
        {
            ListResult = new List<ValidationResult>();
        }

        public abstract void Validate(dynamic value);
    }
}
