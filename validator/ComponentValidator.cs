using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.result;

namespace Validation_Framework.validator
{
    class ComponentValidator : AbstractValidator
    {
        protected readonly Dictionary<string, ValidationPair> fields;

        public ComponentValidator() : base()
        {
            this.fields = new Dictionary<string, ValidationPair>();
        }

        public override List<ValidationResult> Validate(dynamic value)
        {
            listResult.Clear();

            foreach (ValidationPair validationPair in fields.Values)
                listResult.AddRange(validationPair.ValidateAndGetResult(value));

            return listResult;
        }

        public List<ValidationResult> ValidateByName(dynamic value, string nameProperty)
        {
            listResult.Clear();
            if (fields.ContainsKey(nameProperty))
            {
                listResult.AddRange(fields[nameProperty].ValidateAndGetResult(value));
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

        protected virtual void Init()
        {

        }
    }
}
