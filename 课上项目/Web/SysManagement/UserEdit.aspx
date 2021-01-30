<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserEdit.aspx.cs" Inherits="Web.SysManagement.UserEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxUserID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxPWD" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label3" runat="server" Text="学号"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxSID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    <asp:Label ID="Label4" runat="server" Text="工号"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxTID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="ButtonOK" runat="server" Text="提交" OnClick="ButtonOK_Click" />
                    <asp:Button ID="ButtonCancel" runat="server" Text="取消" OnClick="ButtonCancel_Click" />
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
