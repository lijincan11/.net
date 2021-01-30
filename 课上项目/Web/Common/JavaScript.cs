using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Common
{
    public class JavaScript
    {
        public static void Alert(System.Web.UI.Page page,string mas)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "alert",
                "<script language='javascript' defer>alert('" + mas.ToString()
                + "');</script>");
        }

        public static void ControlClickConfirm(System.Web.UI.WebControls.WebControl Control,string msg)
        {
            Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
        }
    }
}