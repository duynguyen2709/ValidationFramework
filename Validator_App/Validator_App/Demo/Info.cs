using Validation_App.Rule;

namespace Validation_App.Demo
{
    public class Info
    {
        [IsEmail]
        public string Email;

        [MinLength(8)]
        [IsPassword(errorMessage: "Khong phai password")]
        public string Password;

        [HasUpperCase("Phai co chu viet hoa")]
        public string Name;

        public string PhoneNumber;

        //[IsNumber]
        //public int ID;

        public Info(string name)
        {
            Name = name;
            //ID = id;
        }
    }
}
