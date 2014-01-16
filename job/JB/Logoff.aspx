<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logoff.aspx.cs" Inherits="JB.Logoff" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/pheonixv1.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function delayer() {
            window.location = "/home";
        }
    </script>
</head>
<body onload="setTimeout('delayer()', 3000)">
    <form id="form1" runat="server">
    <div id="jb_logoutmid">
        <img alt="logging you out" src="images/pl_loader2.gif" />
        <br />
         
        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Logging out please wait..."></asp:Label>
         
    </div>
    </form>
</body>
</html>