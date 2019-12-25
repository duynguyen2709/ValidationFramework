using Validation_App.Rule;

namespace Validation_App.Demo
{
    public class Info
    {
        [IsEmail]
        public string Email;

        [IsPassword(errorMessage: "Khong phai password")]
        public string Password;

        [HasUpperCase("Phai co chu viet hoa")]
        public string Name;

        [IsPhoneNumber]
        public string PhoneNumber;

        [IsDate("Phai dung dinh dang dd/MM/yyyy", "dd'/'MM'/'yyyy")]
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
