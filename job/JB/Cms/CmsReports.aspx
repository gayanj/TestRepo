<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsReports.aspx.cs" Inherits="JB.Cms.Cmsreports" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelreportname" runat="server" Text="Label" CssClass="ft_cmsheading1"></asp:Label>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="100%">
    </rsweb:ReportViewer>
</asp:Content>