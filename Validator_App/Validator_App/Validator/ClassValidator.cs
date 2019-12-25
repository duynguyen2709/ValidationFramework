using System;
using System.Reflection;
using Validation_App.Rule;

namespace Validation_App.Validator
{
    public class ClassValidator : ComponentValidator
    {
        public ClassValidator(Type type)
        {
            foreach (FieldInfo property in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                RuleBuilder builder = RuleBuilder.Create();
                bool hasRule = false;

                foreach (Attribute attribute in property.GetCustomAttributes(typeof(AbstractRule), false))
                {
                    builder.AddRule((attribute as AbstractRule));
                    hasRule = true;
                }

                if (hasRule)
                {
                    SetValidator(property.Name, x => property.GetValue(x), builder.Build());
                }
            }
        }
    }
}
