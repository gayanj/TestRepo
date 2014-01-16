<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbTrends.aspx.cs" Inherits="JB.Jbtrends" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divsimpletop">
     
        <div class="ft_whitebd">
            professions now trending</div>
             
    </div>
    <div class="boxcorner">
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
        </asp:ScriptManager>
        <div class="jbtrendsmid">
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Height="400" Width="100%">
            </rsweb:ReportViewer>
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <br />
    </div>
</asp:Content>