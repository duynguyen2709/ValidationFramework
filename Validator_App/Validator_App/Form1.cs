using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation_App.Demo;
using Validation_App.Result;
using Validation_App.Validator;

namespace Validator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbPhone.Visible = false;
            lbName.Visible = false;
            lbPassword.Visible = false;
            lbBirthdate.Visible = false;
            lbEmail.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            bool isTrue = true;
            Info info = new Info(txtPassword.Text);

            ClassValidator autoValidator = new ClassValidator(typeof(Info));

            
            autoValidator.ValidateByPropertyName(info, nameof(Info.Name)).ForEach(
                x =>
                {
                    if (!x.IsValid)
                    {
                        isTrue = false;
                        lbName.Text = x.ErrorMessage;
                        lbName.Visible = true;
                    }

                }
                );
            if(isTrue)
            {
                lbName.Visible = false;
            }
            //foreach(ValidationResult v in autoValidator)


            //Console.WriteLine("----------------------------------------");

            //autoValidator.ValidateByPropertyName(info, nameof(Info.Name)).ForEach(
            //    x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
            //    );

            //Console.WriteLine("----------------------------------------");

            //UserValidator infoValidate = new UserValidator("2", 3);

            //infoValidate.Validate().ForEach(
            //    x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
            //    );

            //Console.WriteLine("----------------------------------------");

            //infoValidate.ValidateByPropertyName(nameof(UserValidator.Email)).ForEach(
            //    x => Console.WriteLine(x.IsValid + " " + x.ErrorMessage)
            //    );

            //Console.WriteLine("----------------------------------------");
        }
    }
}
