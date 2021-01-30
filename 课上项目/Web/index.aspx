<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>武汉纺织大学学生成绩管理系统</title>
</head>
<frameset rows="96,*" frameborder="NO" framespcing="0">
    <frame src="top.aspx" name="topFrame" scrolling="NO" noresize>
     <frameset cols="180,*" frameborder="NO" framespcing="0">
         <frame src="left.aspx" name="leftFrame" scrolling="YES" noresize>
         <frame src="main.aspx" name="mainFrame">
     </frameset>
   

</frameset>
<body>
    
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
