﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FraudAction.aspx.cs" Inherits="JB.FraudFilters.FraudAction" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/styles/pheonixcm1.css" rel="stylesheet" type="text/css" />
    <link href="/styles/pheonixv1.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body
        {
            background-color: Silver;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="fraudcentermid">
        <asp:Label ID="Label2" runat="server" CssClass="ft_silverh1" Text="!!! Warning !!!"></asp:Label><br />
        <br />
        <asp:Label ID="Label1" runat="server" CssClass="ft_silverh1" Text="Our system has detected script injection in code, please close browser and re-login"></asp:Label>
    </div>
    </form>
</body>
</html>