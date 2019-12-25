using System;

namespace Validator_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.chbRedText = new System.Windows.Forms.CheckBox();
            this.chbPopup = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "BirthDate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Error Display Style:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(138, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(138, 61);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 26);
            this.txtPassword.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(138, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 26);
            this.txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhone.Location = new System.Drawing.Point(138, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(280, 26);
            this.txtPhone.TabIndex = 9;
            // 
            // txtBirthdate
            // 
            this.txtBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBirthdate.Location = new System.Drawing.Point(138, 200);
            this.txtBirthdate.Name = "txtBirthdate";
            this.txtBirthdate.Size = new System.Drawing.Size(280, 26);
            this.txtBirthdate.TabIndex = 10;
            // 
            // chbRedText
            // 
            this.chbRedText.AutoSize = true;
            this.chbRedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chbRedText.Location = new System.Drawing.Point(138, 248);
            this.chbRedText.Name = "chbRedText";
            this.chbRedText.Size = new System.Drawing.Size(88, 24);
            this.chbRedText.TabIndex = 11;
            this.chbRedText.Text = "Red text";
            this.chbRedText.UseVisualStyleBackColor = true;
            // 
            // chbPopup
            // 
            this.chbPopup.AutoSize = true;
            this.chbPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chbPopup.Location = new System.Drawing.Point(297, 248);
            this.chbPopup.Name = "chbPopup";
            this.chbPopup.Size = new System.Drawing.Size(121, 24);
            this.chbPopup.TabIndex = 12;
            this.chbPopup.Text = "Popup/Modal";
            this.chbPopup.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmit.Location = new System.Drawing.Point(199, 278);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 44);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(135, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "label7";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.ForeColor = System.Drawing.Color.Red;
            this.lbPassword.Location = new System.Drawing.Point(135, 90);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(35, 13);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "label8";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(135, 133);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "label9";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.ForeColor = System.Drawing.Color.Red;
            this.lbPhone.Location = new System.Drawing.Point(135, 181);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(41, 13);
            this.lbPhone.TabIndex = 17;
            this.lbPhone.Text = "label10";
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.ForeColor = System.Drawing.Color.Red;
            this.lbBirthdate.Location = new System.Drawing.Point(135, 229);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(41, 13);
            this.lbBirthdate.TabIndex = 18;
            this.lbBirthdate.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 347);
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chbPopup);
            this.Controls.Add(this.chbRedText);
            this.Controls.Add(this.txtBirthdate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        

        

        

       



        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBirthdate;
        private System.Windows.Forms.CheckBox chbRedText;
        private System.Windows.Forms.CheckBox chbPopup;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbBirthdate;
    }
}

