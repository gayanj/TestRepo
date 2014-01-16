<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="SignUp.aspx.cs" Inherits="JB.Recruiters.Signup" %>

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
            Recruiter Registration in progress...
        </div>
    </div>
    <div class="boxcorner">
        <div class="dv_globalmiddle2">
            <div class="ln_fixx10">
            </div>
            <asp:Label ID="Label1" runat="server" CssClass="ft_backhighh1" Text="Signup Form"></asp:Label>
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
            <div class="recruiterformlmarg">
                <div class="cn_appdvleft">
                    <img alt="one" src="/images/nm_one.gif" />
                    <asp:Label ID="Label2" runat="server" Text="Basic Info" CssClass="ft_blackbd"></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label10" runat="server" CssClass="ft_black" Text="First Name"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label11" runat="server" CssClass="ft_black" Text="Last Name"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
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
                <div class="cn_appdvleft">
                    <img alt="two" src="/images/nm_two.gif" />
                    <asp:Label ID="Label3" runat="server" Text="Contact Details" CssClass="ft_blackbd"></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label12" runat="server" CssClass="ft_black" Text="Address1"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label13" runat="server" CssClass="ft_black" Text="Address2"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label14" runat="server" CssClass="ft_black" Text="Address3"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label15" runat="server" CssClass="ft_black" Text="Town"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="TextboxSt" MaxLength="45"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label16" runat="server" CssClass="ft_black" Text="County"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="TextboxSt" MaxLength="45"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label17" runat="server" CssClass="ft_black" Text="PostCode"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="TextboxSt" MaxLength="10"></asp:TextBox>
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
                <div class="cn_appdvleft">
                    <img alt="three" src="/images/nm_three.gif" />
                    <asp:Label ID="Label4" runat="server" Text="Business Profile" CssClass="ft_blackbd"></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label23" runat="server" CssClass="ft_black" Text="Company Name"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="TextboxSt" MaxLength="100"></asp:TextBox>

                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label26" runat="server" CssClass="ft_black" Text="Company Website"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox15" runat="server" CssClass="TextboxSt" MaxLength="500"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label27" runat="server" CssClass="ft_black" Text="Company Intro"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox16" runat="server" CssClass="TextboxSt" Height="50px" TextMode="MultiLine"
                        Wrap="True" MaxLength="500"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label25" runat="server" CssClass="ft_black" Text="Business Detail"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox14" runat="server" CssClass="TextboxSt" Height="100px" TextMode="MultiLine"
                        Wrap="True"></asp:TextBox>
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
                <div class="cn_appdvleft">
                    <img alt="four" src="/images/nm_four.gif" />
                    <asp:Label ID="Label5" runat="server" Text="Login Information" CssClass="ft_blackbd"></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label20" runat="server" CssClass="ft_black" Text="Email"></asp:Label>


                    <br />
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label18" runat="server" CssClass="ft_black" Text="Password"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox12" runat="server" CssClass="TextboxSt" TextMode="Password"
                        MaxLength="45"></asp:TextBox>
                    <asp:PasswordStrength ID="TextBox12_PasswordStrength" runat="server" Enabled="True"
                        TargetControlID="TextBox12" DisplayPosition="BelowLeft" StrengthIndicatorType="BarIndicator"
                        PreferredPasswordLength="10" MinimumNumericCharacters="0" MinimumSymbolCharacters="0"
                        RequiresUpperAndLowerCaseCharacters="false" CalculationWeightings="15;20;15;50"
                        BarBorderCssClass="barIndicatorBorder" StrengthStyles="barIndicator_poor; barIndicator_weak; barIndicator_good; barIndicator_strong; barIndicator_excellent">
                    </asp:PasswordStrength>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label29" runat="server" CssClass="ft_black" Text="Confirm Password"></asp:Label>


                    <br />
                    <asp:TextBox ID="TextBox17" runat="server" CssClass="TextboxSt" TextMode="Password"
                        MaxLength="45"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:Label ID="Label19" runat="server" CssClass="ft_black" Text="Password Hint"></asp:Label>

                    <br />
                    <asp:TextBox ID="TextBox13" runat="server" CssClass="TextboxSt" MaxLength="255"></asp:TextBox>
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
                <div class="cn_appdvleft">
                    <img alt="five" src="/images/nm_five.gif" />
                    <asp:Label ID="Label6" runat="server" Text="Company Logo" CssClass="ft_blackbd"></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="cn_appdvleft">
                    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="ft_black" Width="300px" />

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
                <div class="cn_appdvleft">
                    <uc1:captcha runat="server" id="Captcha" />
                    <asp:TextBox ID="CapText" runat="server" CssClass="TextboxSt"></asp:TextBox>
                </div>
                <div class="dv_fix">
                </div>
                <div>
                    <asp:Label ID="Label31" runat="server" CssClass="ft_red"></asp:Label>
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
                <div class="cn_appdvleft">
                    <asp:Button ID="Button2" runat="server" Text="Signup" CssClass="button" OnClick="Button2Click" />
                    &nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Cancel" CssClass="button" OnClick="Button3Click"
                        CausesValidation="False" />
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx10">
            </div>
            <div class="ln_fixx10">
            </div>
        </div>
    </div>
</asp:Content>
