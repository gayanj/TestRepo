<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="ResProfile.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.ResProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="Objective / Profile" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Please fill in basic objective for your next job this will appear in your profile.
        </div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <asp:Label ID="Label1" runat="server" Text="Profile / Objective" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="250" Height="150" CssClass="cn_txtbox"
                TextMode="MultiLine"></asp:TextBox><br />
            <br />
        </div>
        <div class="resume_center">
            <asp:Button ID="ButtonSave" runat="server" Text="Save & Continue to Education" CssClass="button"
                OnClick="ButtonSave_Click" />
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
