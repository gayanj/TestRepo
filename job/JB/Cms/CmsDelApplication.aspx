<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsDelApplication.aspx.cs" Inherits="JB.Cms.CmsDelApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Deleting Candidate Application" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Are you sure that you want to delete this application!" CssClass="ft_black"></asp:Label>
    <br />
<br />
<asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Delete" />
<asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2_Click" Text="Cancel" />
    <br />
</asp:Content>
