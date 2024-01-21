using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEntityFramework
{
    public partial class FrmTaskListsInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // EF4를 사용하여 데이터 입력

            // 컨텍스트 개체 생성
            Models.TaskDBEntities ctx = new Models.TaskDBEntities();

            // 입력할 개체를 생성
            Models.TaskList task = new Models.TaskList();
            
            task.Name = txtName.Text; // 할일
            task.IsComplete = false; // 아직 실행하지 않음
            task.Priority = lstPriority.SelectedIndex + 1; // 1, 2, 3
            task.DateCreated = DateTime.Now; 

            // 컨텍스트 개체에 입력할 데이터 지정
            ctx.TaskLists.AddObject(task);

            // 실행(Insert/Update/Delete)
            ctx.SaveChanges(); 
        }
    }
}