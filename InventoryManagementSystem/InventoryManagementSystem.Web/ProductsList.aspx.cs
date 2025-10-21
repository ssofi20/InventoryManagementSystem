using InventoryManagementSystem.Data;
using InventoryManagementSystem.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementSystem.Web
{
    public partial class ProductsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductRepository productRepo = new ProductRepository();
            gvProducts.DataSource = productRepo.GetAllProducts();
            gvProducts.DataBind();
        }
    }
}