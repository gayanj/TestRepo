<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsSearchAdvanced.aspx.cs" Inherits="JB.Cms.CmsSearchAdvanced" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Simple Search" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <label for="S1" class="ft_black">Search</label>
    <br />
    <asp:TextBox ID="SearchQuery" runat="server"></asp:TextBox>
    <br />
    <label for="S2" class="ft_black">in</label>
    <br />
    <asp:DropDownList ID="DropDownCriteria" runat="server">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>Recruiters</asp:ListItem>
        <asp:ListItem>Users</asp:ListItem>
        <asp:ListItem>JobSeekers</asp:ListItem>
        <asp:ListItem>Applications</asp:ListItem>
        <asp:ListItem>Advertisements</asp:ListItem>
        <asp:ListItem>Articles</asp:ListItem>
        <asp:ListItem>Salary Categories</asp:ListItem>
        <asp:ListItem>Subsites</asp:ListItem>
        <asp:ListItem>Videos</asp:ListItem>
        <asp:ListItem>Wiki</asp:ListItem>
        <asp:ListItem>Help Categories</asp:ListItem>
        <asp:ListItem>Help Questions</asp:ListItem>
        <asp:ListItem>Help Answers</asp:ListItem>
    </asp:DropDownList>
    <br />
    <label for="Sdate" class="ft_black">From Date</label>
    <br />
    <asp:TextBox ID="TextBoxFrom" runat="server"></asp:TextBox>
    <br />
    <label for="Tdate" class="ft_black">To Date</label>
    <br />
    
    <asp:TextBox ID="TextBoxTo" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="ButtonSearch" runat="server" Text="Search" />
    <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" />


</asp:Content>
