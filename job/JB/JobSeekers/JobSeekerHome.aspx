<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="JobSeekerHome.aspx.cs" Inherits="JB.Jobseekers.Jobseekerhome" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        function loadpg(pgsrc) {
            window.ifra.location = "/Jobseekers/Supportdoc/" + pgsrc;
            return false;
        }
    </script>

    <script src="/Scripts/jqueryvx.js" type="text/javascript"></script>
    <link href="/styles/jqueryvx.js.jscrollpane.css" type="text/css" rel="stylesheet"  />

    <script src="/scripts/scrollv11.js" type="text/javascript"></script>
    <script src="/scripts/scrollv12.js" type="text/javascript"></script>
    <script src="/scripts/scrollv13.js" type="text/javascript"></script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label2" runat="server" CssClass="ft_white" Text="Candidate Dashboard"></asp:Label>
    </div>
    <br />
    <div class="dv_fix">
    </div>
    <div class="time_left">
        <div class="ft_black">
            Here you can find tips which can make your job hunt a lot easier.
        </div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <iframe id="ifra" security="restricted" name="ifra" class="iframes" src="Supportdoc/Cvprepration.htm"></iframe>
        </div>
    </div>
    <div class="jprofilestrength">
        <div class="tb_headone">
            Profile Strength
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_444">
        </div>
        <div class="ln_fixx2">
        </div>
        <asp:Label ID="Label1" runat="server" Text="Visibility :" CssClass="ft_black"></asp:Label>
        <asp:Label ID="LabelStrenght" runat="server" Text="Low" CssClass="ft_black"></asp:Label>
        <asp:Image ID="Image1" runat="server" ImageUrl="/images/profile_low.png" />
        <br />
        <div class="dv_fix">
        </div>
        <asp:Label ID="Label3" runat="server" CssClass="ft_black justify" Text="To increase your public credibility please fill in your personal profile and upload a resume."></asp:Label>
        <br />
        <br />
        <div class="tb_headone">
            Job Statistics
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_444">
        </div>
        <div class="ln_fixx2">
        </div>
        <asp:Label ID="Label5" runat="server" Text="Applications Made: " CssClass="ft_black"></asp:Label>
        <asp:Label ID="LabelJobsAppliedTo" runat="server" Text="0" CssClass="ft_black"></asp:Label>
        <div class="ln_fixx2">
        </div>
        <asp:Label ID="Label6" runat="server" Text="Recruiter Views: " CssClass="ft_black"></asp:Label>
        <asp:Label ID="LabelRecruiterView" runat="server" Text="0" CssClass="ft_black"></asp:Label>
        <div class="ln_fixx2">
        </div>
        <asp:Label ID="Label7" runat="server" Text="Currently: " CssClass="ft_black"></asp:Label>
        <asp:Label ID="LabelCurrentStatus" runat="server" Text="Looking for Work" CssClass="ft_black"></asp:Label>
        <div class="ln_fixx2">
        </div>
        <asp:Label ID="Label8" runat="server" Text="Account Status: " CssClass="ft_black"></asp:Label>
        <asp:Label ID="LabelAccountStatus" runat="server" Text="Active" CssClass="ft_black"></asp:Label>
        <div class="ln_fixx2">
        </div>
        <div class="dv_fix">
        </div>
    </div>
</asp:Content>
