<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditApplication.aspx.cs" Inherits="JB.Cms.CmsEditApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Label ID="Labelheaddetail" runat="server" Text="Updating Application Status" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Candidate FirstName" CssClass="ft_black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxFname" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Candidate LastName" CssClass="ft_black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxLname" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Application Status" CssClass="ft_black"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="0">Selected</asp:ListItem>
        <asp:ListItem Value="2">Rejected</asp:ListItem>
        <asp:ListItem Value="3">Awaiting</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" CssClass="button" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" OnClick="Button2_Click" />
</asp:Content>
