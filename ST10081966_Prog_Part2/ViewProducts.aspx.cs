using ST10081966_Prog_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ST10081966_Prog_Part2
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        DBClass dbClass = new DBClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var myTable = (GridView)FindControl("GridView1");

                GridView1.DataSource = dbClass.GetProductsDataTable();
                GridView1.DataBind();
            }
        }
    }
    

}