using System;
using System.Text;
using Validation_Framework.Demo;
using Validation_Framework.Validator;

namespace Validation_Framework
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // !!! Don't delete this line
            // Print UTF8 character in console
            Console.OutputEncoding = Encoding.UTF8;
            Info info = new Info("112312312312312", 2);

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
        }
    }
}
