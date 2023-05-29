using ST10081966_Prog_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ST10081966_Prog_Part2
{
    public partial class AddFarmer : System.Web.UI.Page
    {
        PasswordClass passwordClass = new PasswordClass();
        DBClass dbClass = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (dbClass.DoesEmailExist(txtEmail.Text))
            {
                DidWorkPopup.Visible = true;
                DidWorkPopup.InnerText = "An error has occured, please ensure your email is unique";
            }
            else
            {
                DidWorkPopup.Visible = false;
                login.Username = txtEmail.Text;
                login.Hash = passwordClass.HashPassword(txtPassword.Text);

                int a = dbClass.SaveLoginID(login);


                Farmer farmer = new Farmer();
                farmer.Firstname = txtName.Text;
                farmer.Surname = txtSurname.Text;
                farmer.Email = txtEmail.Text;
                farmer.PhoneNumber = txtPhone.Text;
                farmer.LoginID = a;

                dbClass.RegisterFarmer(farmer);
            }


        }
    }
}