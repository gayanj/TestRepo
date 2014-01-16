<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbUnsubscribe.aspx.cs" Inherits="JB.jbUnsubscribe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Removing from email list</div>
    </div>
    <div class="boxcorner">
        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Visible="false" Text=""></asp:Label>
    </div>
</asp:Content>
