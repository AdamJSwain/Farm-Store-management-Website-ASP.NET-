using ST10081966_Prog_Part2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ST10081966_Prog_Part2
{
    public partial class AddProduct : System.Web.UI.Page
    {
        DBClass dbClass = new DBClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
               
                product.ProductType = txtType.Text;
                product.ProductName = txtProdName.Text;
                product.DateAdded = DateTime.Now;
                product.Quantity = txtQuantity.Text;
                product.FarmerID = 1;
                
                dbClass.AddProductMethod(product);
            


        }

    }
}