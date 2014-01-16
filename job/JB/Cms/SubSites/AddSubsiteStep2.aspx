<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="AddSubsiteStep2.aspx.cs" Inherits="JB.Cms.Subsites.AddSubsite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cms_step_adjust">
        <div class="cms_step_black">
            <asp:Label ID="Label2" runat="server" Text="Step 1" CssClass="ft_white"></asp:Label>
        </div>
        <div class="cms_step_gray">
            <asp:Label ID="Label3" runat="server" Text="Step 1" CssClass="ft_black"></asp:Label>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Please choose a subsite template, you can customize the designs later, start by chosing a basic template."
        CssClass="ft_black"></asp:Label>
    <div class="ln_dotted">
    </div>
    <div class="cms_subsites">
        <div class="cms_subsite_left">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Template 1" CssClass="ft_blackbd" />
        </div>
        <div class="cms_subsite_right">
            <img src="/images/img_subsite_template1.png" alt="Template 1" /></div>
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotccc">
        </div>
        <br />
        <div class="cms_subsite_left">
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Template 2" CssClass="ft_blackbd" />
        </div>
        <div class="cms_subsite_right">
            <img src="/images/img_subsite_template2.png" alt="Template 2" /></div>
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotccc">
        </div>
        <br />
        <div class="cms_subsite_left">
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Template 3" CssClass="ft_blackbd" />
        </div>
        <div class="cms_subsite_right">
            <img src="/images/img_subsite_template3.png" alt="Template 3" />
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotccc">
        </div>
        <br />
        <asp:Button ID="SaveAction" runat="server" Text="Save and Continue"
            CssClass="button" onclick="SaveAction_Click" />
        <asp:Button ID="CancelAction" runat="server" Text="Cancel" CssClass="button" />
        <br />
        <br />
    </div>
</asp:Content>