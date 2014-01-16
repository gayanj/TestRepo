<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsAddAds.aspx.cs" Inherits="JB.Cms.CmsAddAds" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Add Ads" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Ad Type" CssClass="ft_black"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownAddList" runat="server" AutoPostBack="True">
        <asp:ListItem Value="1">Login Ads</asp:ListItem>
        <asp:ListItem Value="2">Desktop Ads</asp:ListItem>
        <asp:ListItem Value="3">Login Micro Ads</asp:ListItem>
        <asp:ListItem Value="4">Stock Bar Ads</asp:ListItem>
        <asp:ListItem Value="5">Site Header Ads</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Ad Title" CssClass="ft_black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Ad Description" CssClass="ft_black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Ad URL" CssClass="ft_black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Panel ID="PanelImg" runat="server" Visible="False">
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Ad Image" CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="AddImage" runat="server" />
        
    </asp:Panel>
    <br />
    <br />
        
    <asp:Button ID="Button1" runat="server" Text="Save" CssClass="button" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" OnClick="Button2_Click" />
</asp:Content>
