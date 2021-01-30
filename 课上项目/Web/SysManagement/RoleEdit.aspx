<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleEdit.aspx.cs" Inherits="Web.SysManagement.RoleEdit" %>

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
    <form id="form2" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label ID="Label1" runat="server" Text="角色编号"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxRoleID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" align="right">
                    <asp:Label runat="server" Text="角色名称"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBoxRoleName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="ButtonOK" runat="server" Text="提交" OnClick="ButtonOK_Click" />
                    <asp:Button ID="ButtonCancel" runat="server" Text="取消" OnClick="ButtonCancel_Click" style="width: 40px" />
                </td>
            </tr>
            <tr>
                <td align="right" class="auto-style2">
                </td>
                <td class="auto-style2">
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
