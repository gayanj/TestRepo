<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditWiki.aspx.cs" Inherits="JB.Cms.CmsEditWiki" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Label ID="Labelheaddetail" runat="server" Text="Edit Site Wiki Item" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_graysimple" Text="Wiki Title"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt"></asp:TextBox>
    <br />
    <br />    
    <asp:Label ID="Label1" runat="server" CssClass="ft_graysimple" Text="Wiki Description"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save" CssClass="button" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" />
</asp:Content>
