using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebEntityFramework.Models;

namespace WebEntityFramework.Views
{
    public partial class NorthwindProductsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Products 테이블의 모든 레코드를 출력
            NorthwindEntities context = new NorthwindEntities();
            var products = from p in context.Products
                           orderby p.ProductID descending
                           select p;
            this.ctlProductsList.DataSource = products.ToList();
            this.ctlProductsList.DataBind(); 
        }
    }
}