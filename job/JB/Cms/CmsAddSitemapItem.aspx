<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsAddSitemapItem.aspx.cs" Inherits="JB.Cms.CmsSitemapAddItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Adding Sitemap Item" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_black" Text="Item Name">
    </asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Item Description">
    </asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Add"  />
    <asp:Button ID="Button2" runat="server" Text="Cancel" />

</asp:Content>
