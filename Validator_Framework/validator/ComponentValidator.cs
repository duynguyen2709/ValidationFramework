using System;
using System.Collections.Generic;
using Validation_Framework.Result;

namespace Validation_Framework.Validator
{
    public class ComponentValidator : AbstractValidator
    {
        private readonly Dictionary<string, ValidationPair> fields;

        public ComponentValidator() : base()
        {
            // <propertyName, {value : rules}
            fields = new Dictionary<string, ValidationPair>();
        }

        public List<ValidationResult> Validate(dynamic value)
        {
            List<ValidationResult> ListResult = new List<ValidationResult>();

            foreach (ValidationPair validationPair in fields.Values)
            {
                ListResult.AddRange(validationPair.ValidateAndGetResult(value));
            }

            return ListResult;
        }

        public List<ValidationResult> ValidateByPropertyName(dynamic value, string nameProperty)
        {
            if (fields.ContainsKey(nameProperty))
            {
                return fields[nameProperty].ValidateAndGetResult(value);
            }
            return new List<ValidationResult>();
        }

        protected void SetValidator(string name, Func<dynamic, dynamic> func, FieldValidator validator)
        {
            if (fields.ContainsKey(name))
            {
                fields.Remove(name);
            }

            fields.Add(name, new ValidationPair(func, validator));
        }

        private class ValidationPair
        {
            private readonly Func<dynamic, dynamic> func;
            private readonly FieldValidator validator;

            public ValidationPair(Func<dynamic, dynamic> func, FieldValidator validator)
            {
                this.func = func;
                this.validator = validator;
            }

            public List<ValidationResult> ValidateAndGetResult(dynamic target)
            {
                return validator.Validate(func(target));
            }
        }
    }
}
