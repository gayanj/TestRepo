<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="PaymentLanding1.aspx.cs" Inherits="JB.Payments.Paymentlanding1" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Payment processing gateway
        </div>
    </div>
    <div class="boxcorner">
        <asp:Label ID="Label1" runat="server" Text="" CssClass="ft_blackbd"></asp:Label>
    </div>
</asp:Content>
