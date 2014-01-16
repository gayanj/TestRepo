<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JDesktopWidget.aspx.cs" Inherits="JB.Jdesktopwidget" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
         
        <asp:Label ID="reasonforwarded" runat="server" CssClass="ft_whitebd" Text="Desktop Widget"></asp:Label>
         
    </div>
    <div class="boxcorner">
         
        <div class="ft_backhighh1">
            Get the jobs in your local area straight to your desktop!
            <br />
        </div>
        <asp:Label ID="Label3" runat="server" CssClass="ft_gray" Text="Yes we use geo-localization in almost all of our products"></asp:Label>
        .
        <br />
        <br />
        <div class="jdt_widgetlt">
            <img alt="Download widget" src="/images/dt_widget.png" />
        </div>
        <div class="jdt_widgetrt">
            <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Click on the download button to download the widget Install it on your personal computer."></asp:Label>
            <div class="dv_fix">
            </div>
            <br />
            <br />
            <a href="#"><img src="/images/dt_download.png" alt="desktop widget" /></a>
            <br />
            <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="Compatible with windows 2000/xp/vista/7/8"></asp:Label>
        </div>
         
    </div>
</asp:Content>
