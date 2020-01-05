using System;
using System.Text;
using Validation_Framework.Demo;
using Validation_Framework.Rule;
using Validation_Framework.Validator;

namespace Validation_Framework
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // !!! Don't delete this line0
            // Print UTF8 character in console
            Console.OutputEncoding = Encoding.UTF8;
            Info info = new Info("112312312312312Ac", "12/12/2019");

            ClassValidator autoValidator = new ClassValidator(typeof(Info));

            autoValidator.Validate(info).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            autoValidator.ValidateByPropertyName(info, nameof(Info.Name)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            UserValidator infoValidate = new UserValidator("2", 3);

            infoValidate.Validate().ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            infoValidate.ValidateByPropertyName(nameof(UserValidator.Email)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            FieldValidator validator = RuleBuilder.Create()
                                                    .AddRule(new MinLength(8))
                                                    .AddRule(new HasUpperCase())
                                                    .Build();

            string str = "string need to validate";
            validator.Validate(str).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

        }
    }
}
