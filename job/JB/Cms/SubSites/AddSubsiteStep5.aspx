<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="AddSubsiteStep5.aspx.cs" Inherits="JB.Cms.Subsites.AddSubsiteStep5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Subsites" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <div class="subsiteindesign">
        <asp:Label ID="Label10" runat="server" Text="Site Customization" CssClass="ft_blackbd"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Please Customize the look and feel of your site here"
            CssClass="ft_black"></asp:Label>
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <asp:Label ID="Label21" runat="server" Text="Site Font" CssClass="ft_black"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownFontSite" runat="server" CssClass="dropdwn1">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Logo" CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="UploadSiteLogo" runat="server" CssClass="button" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Header" CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="UploadSiteHeader" runat="server" CssClass="button" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Footer" CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="UploadSiteFooter" runat="server" CssClass="button" />
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Site Background" CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="UploadSiteBackground" runat="server" CssClass="button" />
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Site Text Color" CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbSiteTextColor" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Site Footer Text Color" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbSiteFooterTextColor" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <br />
        <br />
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <br />
        <asp:Label ID="Label12" runat="server" Text="Home Page Customization" CssClass="ft_blackbd"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" Text="Categories Font" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownFontHome" runat="server" CssClass="dropdwn1">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Categories Text Color" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbCatTextColor" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Text="Categories Text Hover Color" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbCatTextHoverColor" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label18" runat="server" Text="Categories Background Image" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="UploadhpCatColor" runat="server" CssClass="button" />
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Featured Jobs Background Image" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:FileUpload ID="UploadFeaturedJobs" runat="server" CssClass="button" />
        <br />
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <br />
        <asp:Label ID="Label11" runat="server" Text="Search Page Customization" CssClass="ft_blackbd"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" Text="Search Page Font" 
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownFontSearch" runat="server" CssClass="dropdwn1">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Search Box Background color" CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbSearchBoxbgColor" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <asp:ColorPickerExtender ID="ColorPickerExtender1" runat="server" 
            TargetControlID="TbSearchBoxbgColor">
        </asp:ColorPickerExtender>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Search results, Job title color" CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbSearchResultTitle" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <asp:ColorPickerExtender ID="ColorPickerExtender2" runat="server" 
            TargetControlID="TbSearchResultTitle">
        </asp:ColorPickerExtender>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Search results, Job description color"
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbSearchResultDesc" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <asp:ColorPickerExtender ID="ColorPickerExtender3" runat="server" 
            TargetControlID="TbSearchResultDesc">
        </asp:ColorPickerExtender>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Search results, Recruitername color"
            CssClass="ft_black"></asp:Label>
        <br />
        <asp:TextBox ID="TbSearchResultRecColor" runat="server" CssClass="TextboxSt" 
            Width="50px"></asp:TextBox>
        <asp:ColorPickerExtender ID="ColorPickerExtender4" runat="server" 
            TargetControlID="TbSearchResultRecColor">
        </asp:ColorPickerExtender>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Search Sidebar Background" CssClass="ft_black"></asp:Label>
        <asp:FileUpload ID="UploadSearchSidebar" runat="server" CssClass="button" />
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotted">
        </div>
        <br />
        <asp:Button ID="SaveAction" runat="server" Text="Save and Continue" CssClass="button"
            OnClick="SaveAction_Click" />
        &nbsp;<asp:Button ID="CancelAction" runat="server" Text="Cancel" CssClass="button" />
        <br />
        <br />
    </div>
</asp:Content>
