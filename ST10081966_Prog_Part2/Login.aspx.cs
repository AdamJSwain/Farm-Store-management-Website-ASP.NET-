using ST10081966_Prog_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ST10081966_Prog_Part2
{
    public partial class Login1 : System.Web.UI.Page
    {

        /// <summary>
        ///     SQL DB Connection String
        /// </summary>
        private readonly string ConnectionString = ConfigurationManager.ConnectionStrings["ST10081966DatabaseEntities"].ConnectionString;

        /// <summary>
        ///     SQL Command
        /// </summary>
        private SqlCommand Command;

        /// <summary>
        ///     SQL Connection
        /// </summary>
        private SqlConnection Connection;

        private ST10081966DatabaseEntities Entity;
        DBClass db = new DBClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/EmployeeLogin");
        }

        protected void btnFarmerLogin_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/FarmerLogin");
        }




    }
}