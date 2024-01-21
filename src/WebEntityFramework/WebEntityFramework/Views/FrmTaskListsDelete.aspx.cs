using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEntityFramework
{
	public partial class FrmTaskListsDelete : System.Web.UI.Page
	{
        private Models.TaskDBEntities ctx = new Models.TaskDBEntities();
        
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
		}

        private void DisplayData()
        {
            var q = from t in ctx.TaskLists
                    orderby t.ListId descending
                    select t;
            ctlTaskLists.DataSource = q.ToList();
            ctlTaskLists.DataBind(); 
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // 삭제할 데이터 개체 가져오기
            int listId = Convert.ToInt32(txtListId.Text);
            Models.TaskList task = (from t in ctx.TaskLists
                                   where t.ListId == listId
                                   select t).SingleOrDefault();

            if (task != null)
            {
                // 삭제 데이터 지정
                ctx.TaskLists.DeleteObject(task);
                // 삭제 진행
                ctx.SaveChanges(); 
            }
            else
            {
                lblError.Text = "삭제할 데이터가 없습니다..."; 
            }

            // 다시 출력
            DisplayData(); 
        }
	}
}