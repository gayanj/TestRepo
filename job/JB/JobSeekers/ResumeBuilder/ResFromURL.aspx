<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true" CodeBehind="ResFromURL.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.ResFromURL" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="Skill Cloud" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            You can review your resume in next step once we have converted the url to fit in our system.
        </div>
    </div>
    <div class="time_right">
        <div class="ft_notify">
            <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div class="resume_left">
            <asp:Label ID="LabelResume" runat="server" Text="URL to build resume from" CssClass="ft_black"></asp:Label>
            <asp:TextBox ID="ResResumeLink" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonResume" runat="server" CssClass="button" OnClick="ButtonResume_Click" Text="Build Resume" />
        </div>
        <div class="dv_fix"></div>
        <!-- preview -->
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="LiteralPreview" runat="server" Text="" CssClass="ft_black"></asp:Label>
        </asp:Panel>
    </div>
</asp:Content>
