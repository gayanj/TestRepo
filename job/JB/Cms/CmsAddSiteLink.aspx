<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsAddSiteLink.aspx.cs" Inherits="JB.Cms.CmsAddSiteLink" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Add Site Link Item" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_black" Text="Item Title"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Labeltamplatename0" runat="server" CssClass="ft_black" Text="Item Link"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Image"></asp:Label>
    <br />
    <asp:FileUpload ID="ImageUpload" runat="server" />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="Link Type"></asp:Label>
    <br />
    <asp:DropDownList ID="DropLinkType" runat="server">
        <asp:ListItem Value="0">Header Links</asp:ListItem>
        <asp:ListItem Value="1">Middle Links</asp:ListItem>
        <asp:ListItem Value="2">Footer Links</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" CssClass="button" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" />

</asp:Content>
