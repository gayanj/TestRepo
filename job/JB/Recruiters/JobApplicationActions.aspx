<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="JobApplicationActions.aspx.cs" Inherits="JB.Recruiters.JobApplicationActions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text=" Changing Application Status"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <div class="confirmstyle">
        <asp:Label ID="LabelMessage" runat="server" CssClass="ft_white"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonAccept" runat="server" Text="Yes" CssClass="button" 
            onclick="ButtonAccept_Click" />
        &nbsp;<asp:Button ID="ButtonCancel" runat="server" Text="No" CssClass="button" 
            onclick="ButtonCancel_Click" />
        <br />
    </div>
</asp:Content>
