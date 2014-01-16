<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="Confirm.aspx.cs" Inherits="JB.Payments.Confirm" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <asp:Label ID="reasonforwarded" runat="server" CssClass="ft_whitebd"></asp:Label>
    </div>
    <div class="boxcorner">
        <div class="confirmstyle">
            <asp:Label ID="textreason" runat="server" CssClass="ft_white" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
