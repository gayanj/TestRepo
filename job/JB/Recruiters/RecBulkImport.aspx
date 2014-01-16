<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecBulkImport.aspx.cs" Inherits="JB.Recruiters.Recbulkimport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label14" runat="server" CssClass="ft_white" Text="Bulk Import Data"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Import your data straight away into our system, follow our api documentation
        </div>
    </div>
    <div class="time_right">
        <div id="rc_bulkuploadmid">
            <div class="ft_black">
                Please make sure when uploading bulk data that you check your files for copyright
                infringement. We remove your data from our system if we found out any copyright
                breach and it will result in the account suspension!
                <br />
                <br />
                Specification format for employer and jobs can be found here. Also a detailed policy
                and guidline for data upload can be found here.
                <br />
                <br />
                1- Upload Agents List (this is usually companies list which are imported by you
                into our system) or<br />
                <br />
                2- Upload Jobs (these are jobs which you can bulk import into our system)
                <br />
                <br />
            </div>
            <asp:FileUpload ID="FileUploademployer" runat="server" Enabled="False" />
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" CssClass="ft_black" runat="server">
                <asp:ListItem Selected="True" Value="0">Recruiter Import</asp:ListItem>
                <asp:ListItem Value="1">Jobs</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <br />
            <asp:Button ID="Buttonupload" runat="server" Text="Upload" CssClass="button" OnClick="ButtonuploadClick" Enabled="False" />
            <br />
            <br />
            <div class="ft_black">
                NOTE:
                <br />
                **
                Files should be less them 1mb if you have bigger files split them into 1mb and then
                upload and only in csv comma-delimited format.<br />
                <br />
                * Currently Bulk Uploader is only available under paid accounts or to users who have site contributor privilage.
            </div>
        </div>
    </div>
</asp:Content>
