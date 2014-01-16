<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="SalaryResult.aspx.cs" Inherits="JB.SalaryCalc.Salaryresult" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixs1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Salary Comparison</div>
    </div>
    <div class="boxcorner">
        <div class="dv_salmid">
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
            </asp:ScriptManager>
            <rsweb:ReportViewer ID="ReportViewerSal" runat="server" Height="550" Width="100%">
            </rsweb:ReportViewer>
        </div>
    </div>
</asp:Content>