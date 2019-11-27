using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoValidation.Build
{
    class ComponentValidator : AbstractValidator
    {
        readonly List<ValidationPair> fields;

        public ComponentValidator() : base()
        {
            this.fields = new List<ValidationPair>();
        }

        public override void Validate(dynamic value)
        {
            foreach (ValidationPair validationPair in fields)
            {
                ListResult.AddRange(validationPair.ValidateAndGetResult(value));
            }
        }

        public void SetValidator(Func<dynamic, dynamic> func, AbstractValidator fieldValidator)
        {
            fields.Add(new ValidationPair(func, fieldValidator));
        }
    }
}
