using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation_Framework.builder;
using Validation_Framework.rule;
using Validation_Framework.validator;

namespace Validation_Framework
{
    class Program
    {
        class Info
        {
            [MustBeLargerThan(123)]
            [IsPassword(errorMessage: "Khong phai password")]
            public string Name;

            public int ID; 

            public Info(string name, int id)
            {
                this.Name = name;
                this.ID = id;
            }
        }

        class InfoValidate : CustomValidator
        {
            public string Name;

            public int ID;

            public InfoValidate(string name, int id)
            {
                this.Name = name;
                this.ID = id;
                Init();
            }

            protected override void Init()
            {
                this.SetValidator(nameof(this.Name), x => x.Name,
                                    Builder.Create()
                                    .AddRule(new IsPassword("Khong phai password"))
                                    .AddRule(new IsNumber())
                                    .Build());

                this.SetValidator(nameof(this.ID), x => x.ID,
                                    Builder.Create()
                                    .AddRule(new IsPassword("Khong phai password Nha"))
                                    .AddRule(new IsNumber())
                                    .Build());
            }
        }

        static void Main(string[] args)
        {
            AutoValidator autoValidator = new AutoValidator(typeof(Info));

            autoValidator.Validate(new Info("112312312312312", 2)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(autoValidator.CheckValid(new Info("112312312312312", 2)));

            Console.WriteLine("----------------------------------------");

            autoValidator.ValidateByName(new Info("112312312312312", 2), nameof(Info.ID)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(autoValidator.CheckValidByName(new Info("112312312312312", 2), nameof(Info.ID)));

            Console.WriteLine("*********************************************");

            InfoValidate infoValidate = new InfoValidate("2", 3);

            infoValidate.Validate().ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(infoValidate.CheckValid());

            Console.WriteLine("----------------------------------------");

            infoValidate.ValidateByName(nameof(InfoValidate.Name)).ForEach(
                x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
                );

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(infoValidate.CheckValidByName(nameof(InfoValidate.Name)));

        }
    }
}
