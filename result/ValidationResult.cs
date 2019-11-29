using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation_Framework.result
{
    public class ValidationResult
    {
        private bool isValid;
        private string errorMessage;

        public ValidationResult()
        {
            ErrorMessage = "";
        }

        public ValidationResult(bool isValid, string errorMessage)
        {
            IsValid = isValid;
            ErrorMessage = errorMessage;
        }

        public bool IsValid { get => isValid; set => isValid = value; }
        public string ErrorMessage { get => errorMessage; set => errorMessage = value; }
    }
}
