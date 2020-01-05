using Validation_Framework.Rule;

namespace Validation_App.Demo
{
    public class Info
    {
        [IsEmail]
        public string Email;

        [IsPassword]
        public string Password;

        [HasUpperCase]
        public string Name;

        [IsPhoneNumber]
        public string PhoneNumber;

        [IsDate("dd'/'MM'/'yyyy")]
        public string BirthDate;

        public Info(string email, string password, string name,  string phone, string date)
        {
            Email = email;
            Password = password;
            PhoneNumber = phone;
            BirthDate = date;
            Name = name;
        }
    }
}
