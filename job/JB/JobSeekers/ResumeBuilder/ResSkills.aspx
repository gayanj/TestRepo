<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="ResSkills.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.ResSkills" %>

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
            You can add skills by choosing level of competency from 1 to 5, 1 is beginner and
            5 is expert.
        </div>
    </div>
    <div class="time_right">
        <div class="resume_left">
            <asp:Label ID="Label1" runat="server" Text="Skill Name" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ResSkill"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResSkill" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label28" runat="server" Text="Level of Competency" CssClass="ft_black"></asp:Label>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="ft_black" RepeatDirection="Horizontal"
                RepeatLayout="Flow">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem Selected="True">3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="ButtonAdd" runat="server" Text="Add" CssClass="button" OnClick="ButtonAdd_Click" />
            <br />
        </div>
        <div class="resume_right">
            <div class="tb_headtwo">
                <asp:Label ID="Label2" runat="server" Text="Live Preview"></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <div class="dv_fix">
            </div>
            <asp:Panel ID="PanelSkills" runat="server">
            </asp:Panel>
        </div>
        <div class="dv_fix">
        </div>
        <div class="resume_center">
            <br />
            <asp:Label ID="Label6" runat="server" Text="OR" CssClass="ft_blackbd"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonSave" runat="server" Text="Continue to References" CausesValidation="false"
                CssClass="button" OnClick="ButtonSave_Click" />
        </div>
    </div>
    <div class="dv_fix">
    </div>
</asp:Content>
