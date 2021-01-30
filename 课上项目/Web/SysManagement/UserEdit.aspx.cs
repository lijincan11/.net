using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Common;

namespace Web.SysManagement
{
    public partial class UserEdit : System.Web.UI.Page
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
                        this.TextBoxUserID.ReadOnly = true;
                        WindowsForms_Student.Model.S_User model = new WindowsForms_Student.BLL.S_User().GetModel(id);
                        if (model != null)
                        {
                            this.TextBoxUserID.Text = model.UserID;
                            this.TextBoxPWD.Text = model.UPassWord;
                            this.TextBoxSID.Text = model.SNO;
                            this.TextBoxTID.Text = model.TNO;
                        }
                    }
                }
            }
        }

        protected void ButtonCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("User.aspx");
        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.TextBoxUserID.Text.Trim() == "")
            {
                strErr += "用户名不能为空!\\n";
            }
            if(this.TextBoxPWD.Text.Trim() == "")
            {
                strErr += "用户名不能为空!\\n";
            }
            if (strErr!="")
            {
                JavaScript.Alert(this, strErr);
                return;
            }

            WindowsForms_Student.Model.S_User model = new WindowsForms_Student.Model.S_User();
            model.UserID = this.TextBoxUserID.Text.Trim();
            model.UPassWord = this.TextBoxPWD.Text.Trim();
            model.SNO = this.TextBoxSID.Text.Trim();
            model.TNO = this.TextBoxTID.Text.Trim();
            WindowsForms_Student.BLL.S_User bll = new WindowsForms_Student.BLL.S_User();

            try
            {
                if (EditFlag == "0")
                {
                    bll.Add(model);
                }else if(EditFlag == "1")
                {
                    bll.Update(model);
                }
                
                
                Response.Redirect("User.aspx");
            }
            catch (Exception ex)
            {
                JavaScript.Alert(this, "出错了！\\n" + ex.Message);
                throw;
            }
           
        }
    }
}