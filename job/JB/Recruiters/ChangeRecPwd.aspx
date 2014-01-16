<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true" CodeBehind="ChangeRecPwd.aspx.cs" Inherits="JB.Recruiters.Changerecpwd" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="rc_header">
                <asp:Label ID="Label5" runat="server" CssClass="ft_white" Text="Password Change in progress"></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="time_left">
                <div class="ft_black">
                    Change your login password, a good practice to use strong passwords
                </div>
            </div>
            <div class="time_right">
                <div id="changerecpdscover">
                    <div class="ft_notify">
                        <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="cn_appjobleft">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Old password"></asp:Label>
                    </div>
                    <div class="changerecpwdrts">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxStylerecs" TextMode="Password"
                            MaxLength="45"></asp:TextBox>
                    </div>
                    <div class="dv_fix">
                    </div>

                    <div class="cn_appjobleft">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="New password"></asp:Label>
                    </div>
                    <div class="changerecpwdrts">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxStylerecs" TextMode="Password"
                            MaxLength="45"></asp:TextBox>
                        <asp:PasswordStrength ID="TextBox2_PasswordStrength" runat="server" Enabled="True"
                            TargetControlID="TextBox2" DisplayPosition="BelowLeft" StrengthIndicatorType="BarIndicator"
                            PreferredPasswordLength="10" MinimumNumericCharacters="0" MinimumSymbolCharacters="0"
                            RequiresUpperAndLowerCaseCharacters="false" CalculationWeightings="15;20;15;50"
                            BarBorderCssClass="barIndicatorBorder" StrengthStyles="barIndicator_poor; barIndicator_weak; barIndicator_good; barIndicator_strong; barIndicator_excellent">
                        </asp:PasswordStrength>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="cn_appjobleft">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text="Confirm password"></asp:Label>
                    </div>
                    <div class="changerecpwdrts">
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxStylerecs" TextMode="Password"
                            MaxLength="45"></asp:TextBox>
                        <br />
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="changerecpwdrts">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1Click" Text="Save" CssClass="button" />
                        &nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2Click" Text="Cancel"
                            CssClass="button" CausesValidation="False" />
                    </div>
                    <div class="dv_fix">
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
