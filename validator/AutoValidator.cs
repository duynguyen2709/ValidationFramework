using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.builder;
using Validation_Framework.rule;

namespace Validation_Framework.validator
{
    class AutoValidator : ComponentValidator
    {
        public AutoValidator(Type type)
        {
            foreach (FieldInfo property in type.GetFields())
            {
                Builder builder = Builder.Create();
                bool flag = false;
                foreach (Attribute attribute in property.GetCustomAttributes())
                {
                    if (attribute is AbstractRule)
                    {
                        builder.AddRule((attribute as AbstractRule));
                        flag = true;
                    }
                }
                if (flag)
                {
                    this.SetValidator(property.Name, x => property.GetValue(x), builder.Build());
                }
            }
        }

        public bool CheckValid(dynamic value)
        {
            this.Validate(value);
            return IsValid();
        }

        public bool CheckValidByName(dynamic value, string nameProperty)
        {
            this.ValidateByName(value, nameProperty);
            return IsValid();
        }
    }
}
