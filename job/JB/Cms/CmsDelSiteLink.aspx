<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsDelSiteLink.aspx.cs" Inherits="JB.Cms.CmsDelSiteLink" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <asp:Label ID="Labelheaddetail" runat="server" Text="Delete Site Link" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="Are you sure you want to delete this Link?"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="button" Text="Delete" />
    <asp:Button ID="Button2" runat="server" CssClass="button" Text="Cancel" />
    <br />
    <br />
    <br />
</asp:Content>
