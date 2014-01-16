<%@ Page Title="" Language="C#" MasterPageFile="~/wap/Wap.Master" AutoEventWireup="true"
    CodeBehind="JobApplication.aspx.cs" Inherits="JB.wap.JobApplication" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="m_middleview">
        <div class="ux_notify">
            <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
        </div>
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label2" runat="server" Text="Job Specification"></asp:Label>
        </div>
        <div class="m_jobapptop">
            <asp:Label ID="LabelJobTitle" runat="server" CssClass="m_ft_blue"></asp:Label><br />
            <asp:Label ID="LabelCompany" runat="server" CssClass="m_ft_gray"></asp:Label><br />
            <asp:Label ID="LabelDescription" runat="server" CssClass="m_ft_black"></asp:Label><br />
        </div>
        <!-- application start -->
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label1" runat="server" Text="Application Form"></asp:Label>
        </div>
        <br />
        <asp:Label ID="LabelFName" runat="server" CssClass="m_ft_black"
            Text="First Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxFirstName" runat="server" CssClass="m_simpletextbox"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelLName" runat="server" CssClass="m_ft_black"
            Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxLastName" runat="server" CssClass="m_simpletextbox"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="LabelCover" runat="server" CssClass="m_ft_black"
            Text="Covering Letter"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCover" runat="server" CssClass="m_simpletextbox" TextMode="MultiLine"
            Height="100"></asp:TextBox>
        <br />
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label4" runat="server" Text="Your Education"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label8" runat="server" CssClass="m_ft_black" Text="School Name"></asp:Label>
        <br />
        <asp:TextBox ID="TbSchoolName" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" CssClass="m_ft_black" Text="Degree Name"></asp:Label>
        <br />
        <asp:TextBox ID="TbDegree" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" CssClass="m_ft_black" Text="Start Date"></asp:Label>
        <br />
        <asp:TextBox ID="TbStartDate" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" CssClass="m_ft_black" Text="End Date"></asp:Label>
        <br />
        <asp:TextBox ID="TbEndDate" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" CssClass="m_ft_black" Text="Details"></asp:Label>
        <br />
        <asp:TextBox ID="TbEducationDetail" runat="server" CssClass="m_simpletextbox" TextMode="Multiline" Height="100px"></asp:TextBox>
        <br />
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label5" runat="server" Text="Your Experience"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label13" runat="server" CssClass="m_ft_black" Text="Company Name"></asp:Label>
        <br />
        <asp:TextBox ID="TbCompany" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" CssClass="m_ft_black" Text="Job Title"></asp:Label>
        <br />
        <asp:TextBox ID="TbTitle" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" CssClass="m_ft_black" Text="Start Date"></asp:Label>
        <br />
        <asp:TextBox ID="TbJobStartDate" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" CssClass="m_ft_black" Text="End Date"></asp:Label>
        <br />
        <asp:TextBox ID="TbJobEndDate" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" CssClass="m_ft_black" Text="Details"></asp:Label>
        <br />
        <asp:TextBox ID="TbJobDetails" runat="server" CssClass="m_simpletextbox" TextMode="Multiline" Height="100px"></asp:TextBox>
        <br />
        <br />
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label6" runat="server" Text="Skills"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label18" runat="server" CssClass="m_ft_black" Text="Skill Name"></asp:Label>
        <br />
        <asp:TextBox ID="TSkill" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label7" runat="server" Text="References"></asp:Label>
        </div>
        <br />
        <asp:Label ID="Label24" runat="server" CssClass="m_ft_black" Text="Reference Type"></asp:Label>
        <br />
        <asp:DropDownList ID="DdReference" runat="server">
            <asp:ListItem Value="0">Personal</asp:ListItem>
            <asp:ListItem Value="1">Professional</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" CssClass="m_ft_black" Text="First Name"></asp:Label>
        <br />
        <asp:TextBox ID="TbRefFirstName" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" CssClass="m_ft_black" Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="TbRefLastName" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label21" runat="server" CssClass="m_ft_black" Text="Email"></asp:Label>
        <br />
        <asp:TextBox ID="TbRefEmail" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" CssClass="m_ft_black" Text="Local Phone"></asp:Label>
        <br />
        <asp:TextBox ID="TbLocalPhone" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label25" runat="server" CssClass="m_ft_black" Text="Mobile Phone"></asp:Label>
        <asp:TextBox ID="TbMobilePhone" runat="server" CssClass="m_simpletextbox" TextMode="SingleLine"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label23" runat="server" CssClass="m_ft_black" Text="Address"></asp:Label>
        <br />
        <asp:TextBox ID="TbRefAddress" runat="server" CssClass="m_simpletextbox" TextMode="Multiline" Height="100px"></asp:TextBox>
        <br />
        <br />
        <br />
        <div class="m_decoratedheading">
            <asp:Label ID="Label3" runat="server" Text="Job Questions"></asp:Label>
        </div>
        <div class="m_dv_fix">
            <asp:Panel ID="PanelQuestions" runat="server">
            </asp:Panel>
        </div>
        <br />
        <div class="m_ln_dotted">
        </div>
        <br />
        <asp:Button ID="ButtonApply" runat="server" CssClass="m_button" Text="Apply" OnClick="ButtonApply_Click" />
        <br />
        <br />
    </div>
    </div>
</asp:Content>
