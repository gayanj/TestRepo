<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditHelpAnswer.aspx.cs" Inherits="JB.Cms.CmsEditHelpAnswer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Label ID="Labelheaddetail" runat="server" Text="Edit Site Help Answer" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Labeltamplatename" runat="server" CssClass="ft_black" Text="Please select a question">
    </asp:Label>
    <br />
    <asp:DropDownList ID="DropDownListQs" runat="server"></asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Answer">
    </asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Save"  />
    <asp:Button ID="Button2" runat="server" Text="Cancel"  />
</asp:Content>
