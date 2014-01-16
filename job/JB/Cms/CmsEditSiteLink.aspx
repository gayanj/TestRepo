<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditSiteLink.aspx.cs" Inherits="JB.Cms.CmsEditSiteLink" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:Label ID="Labelheaddetail" runat="server" Text="Editing Site Link Item" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_black" Text="Item Title"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Labeltamplatename0" runat="server" CssClass="ft_black" Text="Item Link"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Image"></asp:Label>
    <br />
    <asp:FileUpload ID="ImageUpload" runat="server" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update"  />
    <asp:Button ID="Button2" runat="server" Text="Cancel"  />
</asp:Content>
