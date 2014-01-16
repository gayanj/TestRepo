<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditModeration.aspx.cs" Inherits="JB.Cms.CmsEditModeration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Labelheaddetail" runat="server" Text="Editing User Moderation" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Moderation Description" CssClass="ft_black"></asp:Label>
    <br />
   
    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Moderation Date" CssClass="ft_black"></asp:Label>
    <br />
   
    <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" CssClass="button" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" />

</asp:Content>
