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
using Validation_Framework.Validator;

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
            bool isTrueName = true;
            bool isTrueEmail = true;
            bool isTruePassword = true;
            bool isTruePhone = true;
            bool isTrueDate = true;

            lbPhone.Visible = false;
            lbName.Visible = false;
            lbPassword.Visible = false;
            lbBirthdate.Visible = false;
            lbEmail.Visible = false;

            Info info = new Info(txtEmail.Text, txtPassword.Text, txtName.Text, txtPhone.Text, txtBirthdate.Text);

            ClassValidator autoValidator = new ClassValidator(typeof(Info));

            //Email
            #region
            autoValidator.ValidateByPropertyName(info, nameof(Info.Email)).ForEach(
                x =>
                {
                    if (!x.IsValid)
                    {
                        if (chbPopup.Checked)
                            MessageBox.Show("Khong phai email", "Error", MessageBoxButtons.OK);
                        else
                        {
                            isTrueEmail = false;
                            lbEmail.Text = x.ErrorMessage;
                            lbEmail.Visible = true;
                        }
                    }

                }
                );
            if (isTrueEmail)
            {
                lbEmail.Visible = false;
            }
            #endregion

            //Password
            #region
            autoValidator.ValidateByPropertyName(info, nameof(Info.Password)).ForEach(
                x =>
                {
                    if (!x.IsValid)
                    {
                        if (chbPopup.Checked)
                            MessageBox.Show("Khong phai password", "Error", MessageBoxButtons.OK);
                        else
                        {
                            isTruePassword = false;
                            lbPassword.Text = x.ErrorMessage;
                            lbPassword.Visible = true;
                        }
                    }

                }
                );
            if (isTruePassword)
            {
                lbPassword.Visible = false;
            }

            #endregion

            //Name
            #region
            autoValidator.ValidateByPropertyName(info, nameof(Info.Name)).ForEach(
                x =>
                {
                    if (!x.IsValid)
                    {
                        if (chbPopup.Checked)
                            MessageBox.Show("Ten khong hop le", "Error", MessageBoxButtons.OK);
                        else
                        {
                            isTrueName = false;
                            lbName.Text = x.ErrorMessage;
                            lbName.Visible = true;
                        }
                    }

                }
                );
            if (isTrueName)
            {
                lbName.Visible = false;
            }
            #endregion

            //Phone
            #region
            autoValidator.ValidateByPropertyName(info, nameof(Info.PhoneNumber)).ForEach(
               x =>
               {
                   if (!x.IsValid)
                   {
                       if (chbPopup.Checked)
                           MessageBox.Show("So dien thoai khong hop le", "Error", MessageBoxButtons.OK);
                       else
                       {
                           isTruePhone = false;
                           lbPhone.Text = x.ErrorMessage;
                           lbPhone.Visible = true;
                       }
                   }

               }
               );
            if (isTruePhone)
            {
                lbPhone.Visible = false;
            }
            #endregion

            //Date
            #region
            autoValidator.ValidateByPropertyName(info, nameof(Info.BirthDate)).ForEach(
                x =>
                {
                    if (!x.IsValid)
                    {
                        if (chbPopup.Checked)
                            MessageBox.Show("Ngay sinh phai co dinh dang dd/MM/yyyy", "Error", MessageBoxButtons.OK);
                        else
                        {
                            isTrueDate = false;
                            lbBirthdate.Text = x.ErrorMessage;
                            lbBirthdate.Visible = true;
                        }
                    }

                }
                );
            if (isTrueDate)
            {
                lbBirthdate.Visible = false;
            }
            #endregion


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

        private void chbRedText_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbPopup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbPopup_MouseClick(object sender, MouseEventArgs e)
        {
            chbRedText.Checked = false;
        }

        private void chbRedText_MouseClick(object sender, MouseEventArgs e)
        {
            chbPopup.Checked = false;
        }
    }
}
