<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="AddSubsiteStep4.aspx.cs" Inherits="JB.Cms.Subsites.AddSubsiteStep4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Subsites" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <div class="dv_fix">
    </div>
    <div class="subsiteindesign">
        <asp:Label ID="Label1" runat="server" Text="Please choose Subsite Categories" CssClass="ft_black"></asp:Label>
        <br />
        <br />
        <div class="ln_dotted">
        </div>
        <br />
        <div class="cms_subsite_maincat">
            <asp:Label ID="Label2" runat="server" Text="Parent Category" CssClass="ft_black"></asp:Label>
            <br />
            <asp:TextBox ID="TextCategory" runat="server" CssClass="TextboxSt" Width="280px"></asp:TextBox>
            <br />
            <br />
            <div class="subsitetxtmid">
                <asp:Button ID="Button1" runat="server" Text="Add Category" CssClass="button" OnClick="Button1_Click" />
            </div>
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <br />
        <div class="cms_subsite_subcat">
            <asp:Label ID="Label3" runat="server" Text="Select Parent Category" CssClass="ft_black"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownCategory" runat="server" Width="280px" 
                CssClass="dropdwn1">
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Sub Category" CssClass="ft_black"></asp:Label>
            <br />
            <asp:TextBox ID="TextSubCategory" runat="server" CssClass="TextboxSt" Width="280px"></asp:TextBox>
            <br />
            <br />
            <div class="subsitetxtmid">
                <asp:Button ID="ButtonSubcat" runat="server" Text="Add Sub Category" CssClass="button"
                    OnClick="ButtonSubcat_Click" />
            </div>
            <br />
        </div>
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
    <div class="subsitepreviewpan">
        <asp:Label ID="Label5" runat="server" Text="Parent Categories" CssClass="ft_blackbd"></asp:Label>
        <br />
        <asp:Panel ID="PanelParentCategories" runat="server">
        </asp:Panel>
        <asp:DropDownList ID="DropDownListPreview" runat="server" CssClass="dropdwn1" 
            AutoPostBack="True" 
            onselectedindexchanged="DropDownListPreview_SelectedIndexChanged" Width="280px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="SubCategories" CssClass="ft_blackbd"></asp:Label>
        <asp:Panel ID="PanelSubCategories" runat="server">
        </asp:Panel>
    </div>
</asp:Content>
