<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="Resume Builder Home" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Either you can build resume from your existing website/link, create a new one with our wizard or why not upload from your computer.
        </div>
    </div>
    <div class="time_right">
            <div id="resume_home">
            <a href="/Jobseekers/Myresumes.aspx" class="res_button shadow wrap">Upload Resume from computer</a>
            <a href="/Jobseekers/ResumeBuilder/ResFromURL.aspx" class="res_button shadow wrap">Build Resume from existing URL/Webpage</a>
            <a href="/Jobseekers/ResumeBuilder/ResHome.aspx" class="res_button shadow wrap">Build Resume using wizard</a>
            </div>
    </div>
    <div class="dv_fix"></div>
    <br />
    <br />
</asp:Content>
