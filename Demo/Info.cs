using Validation_Framework.Rule;

namespace Validation_Framework.Demo
{
    public class Info
    {
        [MinLength(123)]
        [IsPassword(errorMessage: "Khong phai password")]
        public string Name;

        [IsNumber]
        public int ID;

        public Info(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
