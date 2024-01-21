using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEntityFramework
{
    public partial class FrmTaskListsUpdate : System.Web.UI.Page
    {

        // 컨텍스트 개체 생성
        private Models.TaskDBEntities context = new Models.TaskDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            ctlTaskLists.DataSource = context.TaskLists.OrderByDescending(tl => tl.ListId).ToList();
            ctlTaskLists.DataBind(); 
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            // EF4를 사용한 데이터 수정 패턴
            // 수정할 개체 가져오기
            int listId = Convert.ToInt32(txtListId.Text);
            Models.TaskList task = context.TaskLists.Where(t => t.ListId == listId).SingleOrDefault();

            // 수정할 필드 변경
            task.Name = txtName.Text;
            task.Priority = Convert.ToInt32(lstPriority.SelectedValue);
            task.IsComplete = Convert.ToBoolean(chkIsComplete.Checked); 
            // Insert/Delete => Update X

            // 모델에 변경 내역 업데이트
            context.SaveChanges(); 

            // 다시 출력
            DisplayData(); 
        }
    }
}