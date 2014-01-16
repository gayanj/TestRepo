<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="AddSubsiteStep1.aspx.cs" Inherits="JB.Cms.Subsites.AddSubsiteStep1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Subsites" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <div class="subsiteindesign">
        <asp:Label ID="Label1" runat="server" Text="Please choose a unique subsite Name"
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt" Width="280px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Website URL"
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxURL" runat="server" CssClass="TextboxSt" Width="280px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="CheckBoxSubdomain" runat="server" CssClass="ft_black" 
            Text="Is Subdomain of main site" />
        <br />
        <br />
        <asp:Button ID="SaveAction" runat="server" Text="Save and Continue" CssClass="button"
            OnClick="SaveAction_Click" />
        <asp:Button ID="CancelAction" runat="server" Text="Cancel" CssClass="button" />
        <br />
        <br />
    </div>
</asp:Content>
