using System;
using System.Linq;
using WebEntityFramework.Models;

namespace WebEntityFramework
{
    public partial class UsingStoredProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Northwind 모델의 SalesByCategory 저장 프로시저 호출/결과값 출력
            using (var entities = new NorthwindEntities())
            {
                var q = from r in entities.SalesByCategory("Beverages", "1999")
                        select r;

                this.ctlSalesByCategory.DataSource = q.ToList();
                this.ctlSalesByCategory.DataBind(); 
            }
        }
    }
}