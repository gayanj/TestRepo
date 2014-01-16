<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="AddSubsiteStep3.aspx.cs" Inherits="JB.Cms.Subsites.AddSubsiteStep3" %>
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
    <asp:Label ID="Label1" runat="server" Text="Choose a Main / Home Page Template"
        CssClass="ft_black"></asp:Label>
    <div class="ln_dotted">
    </div>
    <div class="cms_subsites">
        <div class="cms_subsite_left">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Template 1" CssClass="ft_blackbd" />
        </div>
        <div class="cms_subsite_right">
            <img src="/images/img_subsite_mainpage1.png" alt="Template 1" /></div>
        <div class="dv_fix">
        </div>
        <br />
        <div class="ln_dotccc">
        </div>
        <br />
       
      
     
       
       
        <asp:Button ID="SaveAction" runat="server" Text="Save and Continue"
            CssClass="button" onclick="SaveAction_Click" />
        <asp:Button ID="CancelAction" runat="server" Text="Cancel" CssClass="button" 
            onclick="CancelAction_Click" />
        <br />
        <br />
    </div>
</asp:Content>
