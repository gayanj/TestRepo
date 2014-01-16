<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="SignUp.aspx.cs" Inherits="JB.Jobseekers.Signup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/UserControls/Captcha.ascx" TagPrefix="uc1" TagName="Captcha" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixbar.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            User Registration in progress...
        </div>
    </div>
    <div class="boxcorner">
        <div class="dv_globalmiddle2">
            <div class="ln_fixx10">
            </div>
            <asp:Label ID="Label15" runat="server" CssClass="ft_backhighh1" Text="Signup Form"></asp:Label>
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
            <br />
            <div class="cn_appdvleft">
                <img alt="one" src="/images/nm_one.gif" />
                <asp:Label ID="Label2" runat="server" Text="Basic Info" CssClass="ft_blackbd"></asp:Label>
            </div>
            <br />
            <div class="dv_fix">
            </div>
            <asp:Label ID="Label10" runat="server" CssClass="ft_black" Text="First Name"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
            <div class="ln_fixx6">
            </div>
            <asp:Label ID="Label11" runat="server" CssClass="ft_black" Text="Last Name"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
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
            <div class="cn_appdvleft">
                <img alt="two" src="/images/nm_two.gif" />
                <asp:Label ID="Label1" runat="server" Text="Login Details" CssClass="ft_blackbd"></asp:Label>
            </div>
            <br />
            <div class="dv_fix">
            </div>
            <asp:Label ID="Label20" runat="server" CssClass="ft_black" Text="Email (Username)"></asp:Label>
            <asp:Label ID="Label26" runat="server" CssClass="ft_red" Text="Email already exist!"
                Visible="False"></asp:Label>
            <asp:TextBox ID="TextBox11" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <asp:Label ID="Label18" runat="server" CssClass="ft_black" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox12" runat="server" CssClass="TextboxSt" TextMode="Password" MaxLength="45"></asp:TextBox>
            <asp:PasswordStrength ID="TextBox12_PasswordStrength" runat="server" Enabled="True"
                TargetControlID="TextBox12" DisplayPosition="BelowLeft" StrengthIndicatorType="BarIndicator"
                PreferredPasswordLength="10" PrefixText="Strength:" TextCssClass="ft_gray" MinimumNumericCharacters="0"
                MinimumSymbolCharacters="0" RequiresUpperAndLowerCaseCharacters="false" CalculationWeightings="15;20;15;50"
                BarBorderCssClass="barIndicatorBorder" StrengthStyles="barIndicator_poor; barIndicator_weak; barIndicator_good; barIndicator_strong; barIndicator_excellent">
            </asp:PasswordStrength>
            <div class="ln_fixx4">
            </div>
            <asp:Label ID="Label28" runat="server" CssClass="ft_black" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="TextBox18" runat="server" CssClass="TextboxSt" TextMode="Password"
                MaxLength="45"></asp:TextBox>
            <div class="ln_fixx4">
            </div>
            <asp:Label ID="Label19" runat="server" CssClass="ft_black" Text="Password Hint"></asp:Label>
            <asp:TextBox ID="TextBox13" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
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
            <uc1:Captcha runat="server" id="Captcha" />
            <asp:TextBox ID="CapText" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <div class="ln_fixx2">
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
            <asp:Button ID="Button2" runat="server" Text="Signup" CssClass="button" OnClick="Button2Click" />
            <asp:Button ID="Button3" runat="server" Text="Cancel" CssClass="button" CausesValidation="False" OnClick="Button3Click" />
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <br />
    </div>
</asp:Content>
