<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="DirectApplication.aspx.cs" Inherits="JB.Jobseekers.Directapplication" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/UserControls/Captcha.ascx" TagPrefix="uc1" TagName="Captcha" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixc1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divsimpletop">
        <asp:Label ID="Label11" runat="server" CssClass="ft_whitebd" Text="CV Upload in progress..."></asp:Label>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="boxcorner">
        <div id="cn_dirappmid">
            <asp:Label ID="Label15" runat="server" CssClass="ft_backhighh1" Text="Quick Uploader"></asp:Label>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx4">
            </div>
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label12" runat="server" CssClass="ft_black" Text="FirstName"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label13" runat="server" CssClass="ft_black" Text="LastName"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label20" runat="server" CssClass="ft_black" Text="Email"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx2">
            </div>
            <div class="ln_dotccc">
            </div>
            <br />
            <div class="dv_fix">
            </div>
            
                <asp:Label ID="Label16" runat="server" CssClass="ft_black" Text="Covering Letter"></asp:Label>
            
            <br />
            
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" Height="100px" TextMode="MultiLine"
                    Wrap="true"></asp:TextBox>
            
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx2">
            </div>
            <div class="ln_dotccc">
            </div>
            <br />
            <div class="dv_fix">
            </div>
            
                <asp:Label ID="Label17" runat="server" CssClass="ft_black" Text="Upload CV"></asp:Label>
                <asp:FileUpload ID="FileUpload2" runat="server" Width="300px" CssClass="ft_black" />
                <div class="ln_fixx4">
                </div>
                <asp:Label ID="Label18" runat="server" CssClass="ft_gray" Text="Only *.docx, *.pdf, *.doc files and less than 500kb"></asp:Label>
            
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx2">
            </div>
            <div class="ln_dotccc">
            </div>
            <br />
            <div class="dv_fix">
            </div>
            <asp:Panel ID="PanelQuestions" runat="server">
            </asp:Panel>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
            <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="By applying at fashionquadrant you are implicitly agreeing with our "></asp:Label>
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_bluelink" NavigateUrl="/terms"
                Target="_blank">Terms</asp:HyperLink>
            <asp:Label ID="Label3" runat="server" Text=" and " CssClass="ft_black"></asp:Label>
            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="ft_bluelink" NavigateUrl="/privacy"
                Target="_blank">Privacy policy.</asp:HyperLink>
            <div class="ln_fixx10">
            </div>
            <asp:Label ID="Label21" runat="server" CssClass="ft_black" Text="NOTE: We will never ask you for any payment neither your credit or debit card numbers or any relating financial information when signing up as a jobseeker."></asp:Label>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx2">
            </div>
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
             <uc1:Captcha runat="server" id="Captcha" />
            <asp:TextBox ID="CapText" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx2">
            </div>
            <div class="ln_dotccc">
            </div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>

            <div class="cn_appdvright">
                <asp:Button ID="Button4" runat="server" CssClass="button" OnClick="Button4Click" Text="Submit" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" CssClass="button" Text="Cancel" OnClick="Button3Click" CausesValidation="False" />
                <br />
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
