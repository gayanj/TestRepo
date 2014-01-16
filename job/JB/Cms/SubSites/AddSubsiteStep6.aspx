<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="AddSubsiteStep6.aspx.cs" Inherits="JB.Cms.Subsites.AddSubsiteStep6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Subsites" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <div class="subsiteindesign">
        <asp:Label ID="Label1" runat="server" Text="Do you want to display Ads on your Subsite? Please enter the Google/Bing or any other ads script for ads in the box below"
            CssClass="ft_black"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Main Page" CssClass="ft_blackbd"></asp:Label>
        <br />
        <asp:TextBox ID="MainPageAdvert" runat="server" CssClass="TextboxSt" Height="100"
            TextMode="MultiLine" Width="280px"></asp:TextBox>
        <br />
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Search Page" CssClass="ft_blackbd"></asp:Label>
        <br />
        <asp:TextBox ID="SearchPageAdvert" runat="server" CssClass="TextboxSt" Height="100"
            TextMode="MultiLine" Width="280px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text="Select multiple items to display adverts on the subsite."></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="CheckHeader" runat="server" CssClass="ft_black" 
            Text="Inside Header" />
        <br />
        <asp:CheckBox ID="CheckSearchCat" runat="server" CssClass="ft_black" 
            Text="Below Search Categories" />
        <br />
        <asp:CheckBox ID="CheckSearchtop" runat="server" CssClass="ft_black" Text="Search Top" />
        <br />
        <asp:CheckBox ID="CheckSearchbottom" runat="server" CssClass="ft_black" Text="Search Bottom" />
        <br />
        <asp:CheckBox ID="CheckSearchRight" runat="server" CssClass="ft_black" 
            Text="Right Side of Search Results" />
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <asp:Label ID="Label2" runat="server" Text="Job Details Page" 
            CssClass="ft_blackbd"></asp:Label>
        <br />
        <asp:TextBox ID="DetailPageAdvert" runat="server" CssClass="TextboxSt" Height="100"
            TextMode="MultiLine" Width="280px"></asp:TextBox>
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <br />


        <asp:Button ID="SaveAction" runat="server" Text="Save and Continue" CssClass="button"
            OnClick="SaveAction_Click" />
        <asp:Button ID="CancelAction" runat="server" Text="Cancel" CssClass="button" />
    </div>
</asp:Content>
