using ST10081966_Prog_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ST10081966_Prog_Part2
{
    public partial class EmployeeLogin : System.Web.UI.Page
    {
        DBClass db = new DBClass();

        ST10081966_Prog_Part2.Classes.LoginStatus userDetails = ST10081966_Prog_Part2.Classes.LoginStatus.Instance;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (db.VerifyEmployeeLogin(txtUsername.Text, txtPassword.Text))
            {
                userDetails.UserID1 = txtUsername.Text;
                userDetails.UserType1 = "Employee";
                Page.Response.Redirect("~/EmployeeHome");
            }
            else
            {
                userDetails.UserType1 = "Employee";
                Page.Response.Redirect("~/Login.aspx");
            }
        }
    }
}