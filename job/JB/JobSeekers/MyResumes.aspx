<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="MyResumes.aspx.cs" Inherits="JB.Jobseekers.Myresumes" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="Resume Management"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Set and update your resumes here, you can use these when applying to jobs</div>
    </div>
    <div class="time_right">
        <div id="cn_canmyresmid">
            <asp:Label ID="Label3" runat="server" Text="Current Resume on File" CssClass="ft_black"></asp:Label>
            <div class="ln_fixx4">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx4">
            </div>
            <asp:Image ID="curresumeimg" runat="server" />
            <asp:HyperLink ID="currresume" runat="server" CssClass="ft_black"></asp:HyperLink>
            <div class="ln_fixx4">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx4">
            </div>
            <asp:Label ID="Label4" runat="server" Text="Change Resume:" CssClass="ft_black"></asp:Label>
            <asp:FileUpload ID="Fupload" runat="server" CssClass="button" />
            <asp:Label ID="Label2" runat="server" CssClass="ft_red" Text=""></asp:Label>
            <div class="ln_fixx4">
            </div>
            <br />
            <asp:Button ID="Buttonsave" runat="server" CssClass="button" Text="Save" OnClick="ButtonsaveClick" />
            &nbsp;<asp:Button ID="Buttoncancel" runat="server" CssClass="button" Text="Cancel"
                OnClick="ButtoncancelClick" />
        </div>
    </div>
</asp:Content>