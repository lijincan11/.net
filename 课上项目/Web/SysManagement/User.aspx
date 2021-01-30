<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Web.SysManagement.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../Common/Check.js" type="text/javascript" charset="gb2312"></script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
        .auto-style3 {
            width: 392px;
        }
        .auto-style4 {
            width: 90px;
        }
        .auto-style5 {
            width: 66px;
        }
        .auto-style6 {
            height: 20px;
            width: 66px;
        }
        .auto-style7 {
            width: 220px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
                        <asp:TextBox ID="UserID" runat="server"></asp:TextBox>
                        <asp:Button ID="ButtonOK" runat="server" OnClick="ButtonOK_Click" Text="查询" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="buttonAdd" runat="server" Text="新增" OnClick="buttonAdd_Click" Width="45px" />
                    </td>
                    <td class="auto-style7" align="right">
                        <asp:Button ID="buttonDel" runat="server" Text="删除" OnClick="buttonDel_Click" />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style2" colspan="3" text-align="center">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="Horizontal" Width="100%" Height="168px" HorizontalAlign="Center" EditRowStyle-HorizontalAlign="Center">
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                            <Columns>
                                <asp:TemplateField HeaderText="选择">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="check" runat="server" />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="UserID" HeaderText="用户名" />
                                <asp:BoundField DataField="UPassWord" HeaderText="密码" />
                                <asp:BoundField DataField="SNO" HeaderText="学号" />
                                <asp:BoundField DataField="TNO" HeaderText="工号" />
                                <asp:HyperLinkField DataNavigateUrlFields="UserID" DataNavigateUrlFormatString="UserEdit.aspx?id={0}" HeaderText="操作" Text="修改">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:HyperLinkField>
                            </Columns>
                            <EditRowStyle BackColor="#999999" />
                            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" />
                            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#E9E7E2" />
                            <SortedAscendingHeaderStyle BackColor="#506C8C" />
                            <SortedDescendingCellStyle BackColor="#FFFDF8" />
                            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td colspan="3"></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
