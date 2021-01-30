<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="Web.left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="Content/Site.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 278px;
        }
        
    </style>
</head>
<body style="margin:0px;padding:0px">
    <form id="form1" runat="server">
        <div class="auto-style1" style="background-color: #0e1031">
            <asp:TreeView ID="TreeView1" runat="server" Height="275px"  Width="180px" align="center" >
                <Nodes >
                    <asp:TreeNode Text="角色设置" Value="学生档案" NavigateUrl="~/SysManagement/Role.aspx" Target="mainFrame"></asp:TreeNode>
                    <asp:TreeNode Text="用户管理" Value="用户管理" NavigateUrl="~/SysManagement/User.aspx" Target="mainFrame"></asp:TreeNode>
                    <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                    <asp:TreeNode Text="新建节点" Value="新建节点"></asp:TreeNode>
                </Nodes>
                
                <NodeStyle ForeColor="#FFCCCC" NodeSpacing="6px" />
                
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
