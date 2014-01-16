<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsLogos.aspx.cs" Inherits="JB.Cms.CmsLogos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Logo Update" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <div class="ux_dividerleft">
        <label for="CurrLogoLabel" class="ft_black">Current Logo</label>
        <br />
        <asp:Image ID="CurrLogoImage" runat="server" />
        <br />
        <br />
    </div>

    <div class="ux_dividerright">
        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="New Logo"></asp:Label>
        <br />
        <asp:FileUpload ID="LogoUpload" runat="server" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" CssClass="button" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" OnClick="Button2_Click" />
    </div>
</asp:Content>
