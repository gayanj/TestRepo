<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsBulkImport.aspx.cs" Inherits="JB.Cms.Cmsbulkimport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Bulk Import" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <div class="ft_black">
        <br />
        Please make sure when uploading bulk data that you check your files for copyright
        infringement. We remove your data from our system if we found out any copyright
        breach and it will result in the account suspension! Specification format for employer
        data import and job data import can be found under the
    </div>
    <a href="/Cms/CmsWiki.aspx" class="ft_bluelink">wiki</a>.
    <div class="ft_black">
        Also a detailed policy and guidline for data upload can be found here.
        <br />
        <br />
        1- Upload Agents List (this is usually companies list which are imported by you
        into our system) or<br />
        <br />
        2- Upload Jobs (these are jobs which you can bulk import into our system)
        <br />
        <br />
    </div>
    <asp:FileUpload ID="FileUploademployer" runat="server" CssClass="button" />
    <br />
    <br />
    <div class="ft_black">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Selected="True" Value="0">Recruiter Import</asp:ListItem>
            <asp:ListItem Value="1">Jobs</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
    </div>
    <asp:Button ID="Buttonupload" runat="server" Text="Upload" CssClass="button" OnClick="Buttonupload_Click" />
    <div class="ft_black">
        <br />
        <br />
        NOTE:
        <br />
        Files should be less them 1mb if you have bigger files split them into 1mb and then
        upload and only in csv comma-delimited format.<br />
    </div>
</asp:Content>
