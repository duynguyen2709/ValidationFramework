using System;
using System.Text;
using Validation_Framework.builder;
using Validation_Framework.rule;
using Validation_Framework.validator;

namespace Validation_Framework
{
    internal class Program
    {
        private class Info
        {
            [MinLength(123)]
            [IsPassword(errorMessage: "Khong phai password")]
            public string Name;

            [IsNumber]
            public int ID;

            public Info(string name, int id)
            {
                this.Name = name;
                this.ID = id;
            }
        }

        private class InfoValidate : CustomValidator
        {
            public string Name;

            public int ID;

            public InfoValidate(string name, int id)
            {
                Name = name;
                ID = id;
                Init();
            }

            protected override void Init()
            {
                SetValidator(nameof(Name), x => x.Name,
                                    Builder.Create()
                                    .AddRule(new IsPassword("Khong phai password"))
                                    .AddRule(new IsNumber())
                                    .Build());

                SetValidator(nameof(ID), x => x.ID,
                                    Builder.Create()
                                    .AddRule(new IsPassword("Khong phai password Nha"))
                                    .AddRule(new IsNumber())
                                    .Build());
            }
        }

        private static void Main(string[] args)
        {
            // !!! Don't delete this line
            // Print UTF8 character in console
            Console.OutputEncoding = Encoding.UTF8;

            AutoValidator autoValidator = new AutoValidator(typeof(Info));

            autoValidator.Validate(new Info("112312312312312", 2)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine(String.Format("Class Valid = {0}", autoValidator.IsValid));
            Console.WriteLine("----------------------------------------");

            autoValidator.ValidateByPropertyName(new Info("112312312312312", 2), nameof(Info.Name)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );
            Console.WriteLine(String.Format("Property Valid = {0}", autoValidator.IsValid));

            Console.WriteLine("----------------------------------------");

            InfoValidate infoValidate = new InfoValidate("2", 3);

            infoValidate.Validate().ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(infoValidate.IsValid);

            Console.WriteLine("----------------------------------------");

            infoValidate.ValidateByPropertyName(nameof(InfoValidate.Name)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");           

        }
    }
}
