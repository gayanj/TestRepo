﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsDelSiteSearch.aspx.cs" Inherits="JB.Cms.CmsDelSiteSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Label ID="Labelheaddetail" runat="server" Text="Deleting Site Search Item" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Are you sure you want to delete this Item!" CssClass="ft_black"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Delete" CssClass="button" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" />
</asp:Content>
