<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="PwdChange.aspx.cs" Inherits="JB.Pwdchange" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="styles/pheonixbar.css" rel="stylesheet" type="text/css" />
    <link href="styles/pheonixv3.css" rel="stylesheet" type="text/css" />
    <link href="styles/pheonixv1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">

        <asp:Label ID="Label13" runat="server" Text="password change in progress" CssClass="ft_whitebd"></asp:Label>

    </div>
    <div class="boxcorner">

        <div class="pwd_chgmid">
            <div class="setleftdiv">
                <asp:Label ID="Label1" runat="server" Text="New password" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt" TextMode="Password"
                    Width="200px"></asp:TextBox>
                <asp:PasswordStrength ID="TextBox12_PasswordStrength" runat="server" Enabled="True"
                    TargetControlID="TextBox1" DisplayPosition="BelowLeft" StrengthIndicatorType="BarIndicator"
                    PreferredPasswordLength="10" MinimumNumericCharacters="0" MinimumSymbolCharacters="0"
                    RequiresUpperAndLowerCaseCharacters="false" CalculationWeightings="15;20;15;50"
                    BarBorderCssClass="barIndicatorBorder" StrengthStyles="barIndicator_poor; barIndicator_weak; barIndicator_good; barIndicator_strong; barIndicator_excellent">
                </asp:PasswordStrength>
                <br />
                <br />
            </div>
            <div class="setleftdiv">
                <asp:Label ID="Label2" runat="server" Text="Confirm password" CssClass="ft_black"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            </div>
            <div>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" TextMode="Password"
                    Width="200px"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="setleftdivw1">
                <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="button" OnClick="Button1Click" />
            </div>
            <div>
                <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" CausesValidation="False"
                    OnClick="Button2Click" />
            </div>
        </div>

    </div>
</asp:Content>
