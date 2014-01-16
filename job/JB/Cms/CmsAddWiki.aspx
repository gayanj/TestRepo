<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsAddWiki.aspx.cs" Inherits="JB.Cms.CmsAddWiki" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Add Site Wiki Item" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_black" Text="Wiki Title"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt"></asp:TextBox>
    <br />
    <br />    
    <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Wiki Description"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Add" CssClass="button" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" />
</asp:Content>
