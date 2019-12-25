using System;
using System.Collections.Generic;
using Validation_App.Result;

namespace Validation_App.Validator
{
    internal class CustomValidator : ComponentValidator
    {
        public List<ValidationResult> Validate()
        {
            List<ValidationResult> result = new List<ValidationResult>();
            try
            {
                result = Validate(this);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                ValidationResult err = new ValidationResult(false, e.Message);
            }
            return result;
        }
        public List<ValidationResult> ValidateByPropertyName(string propertyName)
        {
            List<ValidationResult> result = new List<ValidationResult>();
            try
            {
                result = ValidateByPropertyName(this, propertyName);
            }
            catch (Exception)
            {
                ValidationResult err = new ValidationResult(false, string.Format("Property {0} Not Found", propertyName));
            }
            return result;
        }
    }
}
