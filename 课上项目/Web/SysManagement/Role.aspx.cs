using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.SysManagement
{
    public partial class Role : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                buttonDel.OnClientClick = "return CheckDelete('" + this.GridView1.ClientID + "')";
                this.GridView1.DataKeyNames = new string[] { "RoleID" };//关键字
                this.ButtonOK_Click(this.ButtonOK, e);
            }
        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            WindowsForms_Student.BLL.Core bll = new WindowsForms_Student.BLL.Core();
            string RoleID = this.RoleID.Text.Trim();
            this.GridView1.DataSource = bll.GetRoleList(RoleID).Tables[0];
            this.GridView1.DataBind();//数据绑定
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoleEdit.aspx?id=0");
        }

        protected void buttonDel_Click(object sender, EventArgs e)
        {
            string idList = "";
            foreach (GridViewRow row in this.GridView1.Rows)
            {
                CheckBox cb = (CheckBox)row.FindControl("check");
                
                if (cb != null && cb.Checked == true)
                    idList += "'" + GridView1.DataKeys[row.RowIndex]["RoleID"].ToString() + "',";
            }
            idList = idList.TrimEnd(',');
            try
            {
                new WindowsForms_Student.BLL.S_Role().DeleteList(idList);
                Common.JavaScript.Alert(this, "删除成功");
                this.ButtonOK_Click(this.ButtonOK, e);//刷新数据
            }
            catch (Exception ex)
            {
                Common.JavaScript.Alert(this, "删除失败!" + ex.Message);
                throw;
            }
        }
    }
}