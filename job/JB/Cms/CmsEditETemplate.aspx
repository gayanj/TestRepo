<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditETemplate.aspx.cs" Inherits="JB.Cms.CmsEditETemplate" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Edit Email Template" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_graysimple" Text="Template Name">
    </asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Labelheading1" runat="server" CssClass="ft_graysimple" Text="Header"></asp:Label>
    <cc1:Editor ID="Editor2" runat="server" />
    <br />
    <asp:Label ID="Labelheading2" runat="server" CssClass="ft_graysimple" Text="Middle"></asp:Label>
    <cc1:Editor ID="Editor1" runat="server" />
    <br />
    <asp:Label ID="Labelheading3" runat="server" CssClass="ft_graysimple" Text="Footer"></asp:Label>
    <br />
    <cc1:Editor ID="Editor3" runat="server" />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Edit Template" CssClass="button" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" />

</asp:Content>
