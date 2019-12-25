using Validation_Framework.Rule;

namespace Validation_Framework.Demo
{
    public class Info
    {
        [MinLength(8)]
        [IsPassword(errorMessage: "Khong phai password")]
        public string Name;

        [IsDate("dd'/'MM'/'yyyy")]
        public string date;

        public Info(string name, string date)
        {
            Name = name;
            this.date = date;
        }
    }
}
