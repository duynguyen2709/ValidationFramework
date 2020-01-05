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
        bool isFirstTimeClickName = true;
        bool isFirstTimeClickPassword = true;
        bool isFirstTimeClickPhone = true;
        bool isFirstTimeClickDate = true;
        bool isFirstTimeClickEmail = true;

        public Form1()
        {
            InitializeComponent();
            lbPhone.Visible = false;
            lbName.Visible = false;
            lbPassword.Visible = false;
            lbBirthdate.Visible = false;
            lbEmail.Visible = false;
            txtEmail.Text = "Phải có định dạng local-part@domain name";
            txtPassword.Text = "Phải có ít nhất 8 kí tự, trong đó có ít nhất 1 chữ in hoa và 1 chữ số";
            txtPhone.Text = "Phải có đúng 10 chữ số, bắt đầu bằng chữ số 0";
            txtName.Text = "Phải có một chữ in hoa";
            txtBirthdate.Text = "Phải có định dạng dd/MM/yyyy";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isTrueName = true;
            bool isTrueEmail = true;
            bool isTruePassword = true;
            bool isTruePhone = true;
            bool isTrueDate = true;
            //bool isPopUpShowed = false;

            string CheckBoxErrorString = "";

            lbPhone.Visible = false;
            lbName.Visible = false;
            lbPassword.Visible = false;
            lbBirthdate.Visible = false;
            lbEmail.Visible = false;

            if (isFirstTimeClickEmail)
                txtEmail.Text = "";
            if (isFirstTimeClickDate)
                txtBirthdate.Text = "";
            if (isFirstTimeClickName)
                txtName.Text = "";
            if (isFirstTimeClickPassword)
                txtPassword.Text = "";
            if (isFirstTimeClickPhone)
                txtPhone.Text = "";

            Info info = new Info(txtEmail.Text, txtPassword.Text, txtName.Text, txtPhone.Text, txtBirthdate.Text);

            ClassValidator autoValidator = new ClassValidator(typeof(Info));

            //Email
            #region
            autoValidator.ValidateByPropertyName(info, nameof(Info.Email)).ForEach(
                x =>
                {
                    if (!x.IsValid)
                    {
                        if (chbPopup.Checked) {
                            //if (!isPopUpShowed)
                            //{
                            //    MessageBox.Show("Email: " + x.ErrorMessage, "Error", MessageBoxButtons.OK);
                            //    isPopUpShowed = true;
                            //}

                            CheckBoxErrorString += "Email: " + x.ErrorMessage + "\n";
                        }
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
                        {
                            //if (!isPopUpShowed)
                            //{
                            //    MessageBox.Show("Password: " + x.ErrorMessage, "Error", MessageBoxButtons.OK);
                            //    isPopUpShowed = true;
                            //}

                            CheckBoxErrorString += "Password: " + x.ErrorMessage + "\n";
                        }
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
                        {
                            //if (!isPopUpShowed)
                            //{
                            //    MessageBox.Show("Name: " + x.ErrorMessage, "Error", MessageBoxButtons.OK);
                            //    isPopUpShowed = true;
                            //}

                            CheckBoxErrorString += "Name: " + x.ErrorMessage + "\n";
                        }
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
                       {
                           //if (!isPopUpShowed)
                           //{
                           //    MessageBox.Show("Phone number: " + x.ErrorMessage, "Error", MessageBoxButtons.OK);
                           //    isPopUpShowed = true;
                           //}

                           CheckBoxErrorString += "Phone number: " + x.ErrorMessage + "\n";
                       }
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
                        {
                            //if (!isPopUpShowed)
                            //{
                            //    MessageBox.Show("Date: " + x.ErrorMessage, "Error", MessageBoxButtons.OK);
                            //    isPopUpShowed = true;
                            //}

                            CheckBoxErrorString += "Date: " + x.ErrorMessage + "\n";
                        }
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

            if (chbPopup.Checked)
            {
                MessageBox.Show(CheckBoxErrorString, "Error", MessageBoxButtons.OK);
            }
           
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

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if(isFirstTimeClickEmail)
            { 
                txtEmail.Text = "";
                isFirstTimeClickEmail = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (isFirstTimeClickPassword)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                isFirstTimeClickPassword = false;
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if (isFirstTimeClickName)
            {
                txtName.Text = "";
                isFirstTimeClickName = false;
            }
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            if (isFirstTimeClickPhone)
            {
                txtPhone.Text = "";
                isFirstTimeClickPhone = false;
            }
        }

        private void txtBirthdate_Click(object sender, EventArgs e)
        {
            if (isFirstTimeClickDate)
            {
                txtBirthdate.Text = "";
                isFirstTimeClickDate = false;
            }
        }
    }
}
