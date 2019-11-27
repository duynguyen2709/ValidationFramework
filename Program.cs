using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info info = new Info("asd", "as");
            //Validator validator = new Validator();
            //validator.Validate(info);

            Thongtin thongtin = new Thongtin("asd", "asd", new Address("asd", "asdas"));
            ThongtinValidator thongtinValidator = new ThongtinValidator();
            thongtinValidator.Validate(thongtin);
        }
    }
}
