<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEditArticle.aspx.cs" Inherits="JB.Cms.CmsEditArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <asp:Label ID="Labelheaddetail" runat="server" Text="Updating Article Status" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Article Name" CssClass="ft_black"></asp:Label>
      <br />
      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
      <br />
      <br />
    <asp:Label ID="Label3" runat="server" Text="Article Theme" CssClass="ft_black"></asp:Label>
      <br />
      <asp:DropDownList ID="DropDownListTheme" runat="server">
          <asp:ListItem>Green</asp:ListItem>
          <asp:ListItem>Red</asp:ListItem>
          <asp:ListItem>Blue</asp:ListItem>
      </asp:DropDownList>
      <br />
      <br />
    <asp:Label ID="Label4" runat="server" Text="Article Description" CssClass="ft_black"></asp:Label>
      <br />
      <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
      <br />
      <br />
      <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Update" />
      <asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2_Click" Text="Cancel" />
    <br />
  
</asp:Content>
