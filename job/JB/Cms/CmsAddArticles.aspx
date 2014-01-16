<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsAddArticles.aspx.cs" Inherits="JB.Cms.Cmsarticles" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Add Articles" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labelartname" runat="server" Text="Article Name" CssClass="ft_black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxarticlename" runat="server" CssClass="TextboxSt"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxarticlename"
        CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="Theme"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" >
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Labelartdata" runat="server" Text="Article Body" CssClass="ft_black"></asp:Label>
    <cc1:Editor ID="Editor1" runat="server" />
    <br />
    <asp:Button ID="Buttonsave" runat="server" Text="Save" OnClick="Buttonsave_Click"
        CssClass="button" />
    <asp:Button ID="ActionCancel" runat="server" Text="Cancel" CssClass="button" />
</asp:Content>