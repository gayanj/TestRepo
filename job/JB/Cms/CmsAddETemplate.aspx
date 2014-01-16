<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsAddETemplate.aspx.cs" Inherits="JB.Cms.CmsEmailtemplates" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Add Email Template" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc"></div>
    <div>
        <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_black" Text="Template Name">
        </asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Labelheading1" runat="server" CssClass="ft_black" Text="Header"></asp:Label>
        <cc1:Editor ID="Editor2" runat="server" />
        <br />
        <asp:Label ID="Labelheading2" runat="server" CssClass="ft_black" Text="Middle"></asp:Label>
        <cc1:Editor ID="Editor1" runat="server" />
        <br />
        <asp:Label ID="Labelheading3" runat="server" CssClass="ft_black" Text="Footer"></asp:Label>
        <br />
        <cc1:Editor ID="Editor3" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Template"  />
        <asp:Button ID="Button2" runat="server" Text="Cancel"  />
    </div>
</asp:Content>
