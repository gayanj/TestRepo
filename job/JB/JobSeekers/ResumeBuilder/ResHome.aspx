<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="ResHome.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.ResHome" %>

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
            Fill in sections to complete the resume profile. Once you fill a section you will see complete in front of that.
        </div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <div class="tb_headzero">
                Profile
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <asp:Label ID="Label1" runat="server" Text="Status :" CssClass="ft_black"></asp:Label>
            <asp:Label ID="StatusProfile" runat="server" Text="Incomplete" 
                CssClass="ft_black"></asp:Label>
            <br />
            <asp:HyperLink ID="LinkProfileNew" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResProfile.aspx">Complete this Section</asp:HyperLink>
            <asp:HyperLink ID="LinkProfileEdit" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResProfile.aspx?redit=1" Visible="False">Edit</asp:HyperLink>
            <div class="dv_fix">
            </div>
            <br />
            <div class="tb_headzero">
                Education
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <asp:Label ID="Label3" runat="server" Text="Status :" CssClass="ft_black"></asp:Label>
            <asp:Label ID="StatusEducation" runat="server" Text="Incomplete" 
                CssClass="ft_black"></asp:Label>
            <br />
            <asp:HyperLink ID="LinkEducationNew" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResEducation.aspx">Complete this Section</asp:HyperLink>
            <asp:HyperLink ID="LinkEducationEdit" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResEducation.aspx" Visible="False">Edit</asp:HyperLink>
            <div class="dv_fix">
            </div>
            <br />
            <div class="tb_headzero">
                Experience
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <asp:Label ID="Label2" runat="server" Text="Status :" CssClass="ft_black"></asp:Label>
            <asp:Label ID="StatusExperience" runat="server" Text="Incomplete" 
                CssClass="ft_black"></asp:Label>
            <br />
            <asp:HyperLink ID="LinkExperienceNew" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResExperience.aspx">Complete this Section</asp:HyperLink>
            <asp:HyperLink ID="LinkExperienceEdit" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResExperience.aspx" Visible="False">Edit</asp:HyperLink>
            <div class="dv_fix">
            </div>
            <br />
            <div class="tb_headzero">
                Skills
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <asp:Label ID="Label4" runat="server" Text="Status :" CssClass="ft_black"></asp:Label>
            <asp:Label ID="StatusSkills" runat="server" Text="Incomplete" 
                CssClass="ft_black"></asp:Label>
            <br />
            <asp:HyperLink ID="LinkSkillsNew" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResSkills.aspx">Complete this Section</asp:HyperLink>
            <asp:HyperLink ID="LinkSkillsEdit" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResSkills.aspx" Visible="False">Edit</asp:HyperLink>
            <div class="dv_fix">
            </div>
            <br />
            <div class="tb_headzero">
                References
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <asp:Label ID="Label5" runat="server" Text="Status :" CssClass="ft_black"></asp:Label>
            <asp:Label ID="StatusReferences" runat="server" Text="Incomplete" 
                CssClass="ft_black"></asp:Label>
            <br />
            <asp:HyperLink ID="LinkReferenceNew" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResReferences.aspx">Complete this Section</asp:HyperLink>
            <asp:HyperLink ID="LinkReferenceEdit" runat="server" CssClass="ft_bluelink" 
                NavigateUrl="~/Jobseekers/ResumeBuilder/ResReferences.aspx" Visible="False">Edit</asp:HyperLink>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
