<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditHelpCategory.aspx.cs" Inherits="JB.Cms.CmsEditHelpCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Label ID="Labelheaddetail" runat="server" Text="Edit Site Help Category" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Category">
    </asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server"  ></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" />
</asp:Content>
