using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DemoValidation.Build;
using DemoValidation.Rule;

namespace DemoValidation
{
    class Info
    {
        [MustBeLargerThan("Sai", 3)]
        public string Name;
        [IsEmail("Không phải Email")]
        public string Email;

        public Info(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }

    class Address
    {
        public string Quan;
        public string Phuong;
        public Address(string quan, string phuong)
        {
            this.Quan = quan;
            this.Phuong = phuong;
        }
    }

    abstract class AbstractAttrbute : Attribute
    {
        public abstract void Validate(object input);
    }

    class IsEmail : AbstractAttrbute
    {
        public string Message;
        public bool IsValid = true;

        public IsEmail(string message)
        {
            this.Message = message;
        }
        public override void Validate(object input)
        {
            if (input.ToString() == "a")
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
                Console.WriteLine(Message);
            }
        }
    }

    class MustBeLargerThan : AbstractAttrbute
    {
        public string Message;
        public int X;
        public bool IsValid = true;

        public MustBeLargerThan(string message, int x)
        {
            this.Message = message;
            this.X = x;
        }
        public override void Validate(object input)
        {
            if (input.ToString().Length > X)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
                Console.WriteLine(Message);
            }
        }
    }

    class MustBeSmallThan : AbstractAttrbute
    {
        public string Message;
        public int X;
        public bool IsValid = true;

        public MustBeSmallThan(string message, int x)
        {
            this.Message = message;
            this.X = x;
        }
        public override void Validate(object input)
        {
            if (input.ToString().Length > X)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
                Console.WriteLine(Message);
            }
        }
    }

    class Validator
    {
        public void Validate(object Object)
        {
            foreach (FieldInfo property in Object.GetType().GetFields())
            {
                foreach (AbstractAttrbute attribute in property.GetCustomAttributes())
                {
                    attribute.Validate(property.GetValue(Object));
                }
            }
        }
    }

    class Thongtin
    {
        public string Name;
        public string ID;
        public Address Address;
        public Thongtin(string name, string id, Address address)
        {
            this.Name = name;
            this.ID = id;
            this.Address = address;
        }
    }

    class AddressValidator : ComponentValidator
    {
        public AddressValidator()
        {
            FieldValidator fieldValidator = Builder.Create()
                                                .AddRule(new IsPasswordRule("Khong phai Quan"))
                                                .Build();
            this.SetValidator(x => x.Quan, fieldValidator);

            FieldValidator fieldValidator1 = Builder.Create()
                                                .AddRule(new IsNumberRule("Khong phai Phuong"))
                                                .Build();
            this.SetValidator(x => x.Phuong, fieldValidator1);
        }
    }

    class ThongtinValidator : ComponentValidator
    {
        public ThongtinValidator()
        {
            FieldValidator fieldValidator = Builder.Create()
                                                .AddRule(new IsPasswordRule("Khong phai password"))
                                                .Build();
            this.SetValidator(x => x.Name, fieldValidator);

            FieldValidator fieldValidator1 = Builder.Create()                                              
                                                .AddRule(new IsNumberRule("Khong phai so"))
                                                .Build();
            this.SetValidator(x => x.ID, fieldValidator1);

            this.SetValidator(x => x.Address, new AddressValidator());
        }
    }
}
