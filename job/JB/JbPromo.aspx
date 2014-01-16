<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbPromo.aspx.cs" Inherits="JB.Jbpromo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Promotions at gq jobs</div>
    </div>
    <div class="boxcorner">
        <asp:Panel ID="Panel1" CssClass="leftpromo" runat="server">
            <img src="/images/promopack1.jpg" />
            <br />
            <div class="dv_fix" css>
            </div>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Signup for promotion &gt;&gt;&gt;"
                CssClass="button" OnClick="Button1Click" />
            <br />
            <br />
        </asp:Panel>
    </div>
</asp:Content>