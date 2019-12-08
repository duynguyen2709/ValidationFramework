using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.CustomException;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    public class ComponentValidator : AbstractValidator
    {
        protected readonly Dictionary<string, ValidationPair> fields;

        public ComponentValidator() : base()
        {
            // <propertyName, {value : rules}
            fields = new Dictionary<string, ValidationPair>();
        }

        public override List<ValidationResult> Validate(dynamic value)
        {
            ListResult.Clear();

            foreach (ValidationPair validationPair in fields.Values)
                ListResult.AddRange(validationPair.ValidateAndGetResult(value));

            return ListResult;
        }

        public List<ValidationResult> ValidateByPropertyName(dynamic value, string nameProperty)
        {
            ListResult.Clear();
            if (fields.ContainsKey(nameProperty))
            {
                ListResult.AddRange(fields[nameProperty].ValidateAndGetResult(value));
                return fields[nameProperty].ValidateAndGetResult(value);
            }
            else
            {
                throw new PropertyNotFoundException(nameProperty);
            }
        }

        protected void SetValidator(string name, Func<dynamic, dynamic> func, FieldValidator validator)
        {
            if (fields.ContainsKey(name))
            {
                fields.Remove(name);
            }

            fields.Add(name, new ValidationPair(func, validator));
        }

        protected virtual void Init()
        {}
    }
}
