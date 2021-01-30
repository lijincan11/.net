using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

namespace Web.SysManagement
{
    public partial class RoleEdit : System.Web.UI.Page
    {
        protected string EditFlag
        {
            set { ViewState["editFlag"] = value; }
            get { return ViewState["editFlag"].ToString(); }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                JavaScript.ControlClickConfirm(this.ButtonOK, "你确实提交数据吗？");
                string id = "";
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    id = Request.Params["id"].ToString();
                    if (id == "0")//新增
                    {
                        EditFlag = "0";
                    }
                    else//修改
                    {
                        EditFlag = "1";
                        this.TextBoxRoleID.ReadOnly = true;
                        WindowsForms_Student.Model.S_Role model = new WindowsForms_Student.BLL.S_Role().GetModel(id);
                        if (model != null)
                        {
                            this.TextBoxRoleID.Text = model.RoleID;
                            this.TextBoxRoleName.Text = model.RoleName;
                            
                        }
                    }
                }
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Role.aspx");
        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.TextBoxRoleID.Text.Trim() == "")
            {
                strErr += "角色编号不能为空!\\n";
            }
            if (this.TextBoxRoleName.Text.Trim() == "")
            {
                strErr += "角色名不能为空!\\n";
            }
            if (strErr != "")
            {
                JavaScript.Alert(this, strErr);
                return;
            }

            WindowsForms_Student.Model.S_Role model = new WindowsForms_Student.Model.S_Role();
            model.RoleID = this.TextBoxRoleID.Text.Trim();
            model.RoleName = this.TextBoxRoleName.Text.Trim();
           
            WindowsForms_Student.BLL.S_Role bll = new WindowsForms_Student.BLL.S_Role();

            try
            {
                if (EditFlag == "0")
                {
                    bll.Add(model);
                }
                else if (EditFlag == "1")
                {
                    bll.Update(model);
                }


                Response.Redirect("Role.aspx");
            }
            catch (Exception ex)
            {
                JavaScript.Alert(this, "出错了！\\n" + ex.Message);
                throw;
            }
        }
    }
}