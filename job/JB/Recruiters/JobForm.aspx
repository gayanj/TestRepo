<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="JobForm.aspx.cs" Inherits="JB.Recruiters.JobForm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--begin scroll-->
    <link href="/styles/pheonixv6.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jqueryvx.js" type="text/javascript"></script>
    <link type="text/css" href="/styles/jquery.jscrollpane.css" rel="stylesheet" media="all" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="rc_header">
        <asp:Label ID="Label14" runat="server" CssClass="ft_white" Text="Post Jobs"></asp:Label>
    </div>
    <div class="bg_black">
        <div class="ft_white">
            Step 1 of 3
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Post jobs, Set search criteria, add questions, add videos and a lot more
        </div>
    </div>
    <div class="time_right">
        <div id="jobformcent">

            <div class="cn_appjobleft">
                <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="JobTitle"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="X"
                    ControlToValidate="TextBox1" CssClass="ft_red"></asp:RequiredFieldValidator>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="jobformleftdiv">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxStylerecs" MaxLength="70"></asp:TextBox>
                        <asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2Click"
                            Text="Suggestions" CausesValidation="false" Visible="false" />
                    </div>
                    <asp:Panel ID="Suggestionpanel" runat="server">
                    </asp:Panel>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="Short Description"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="X"
                    ControlToValidate="TextBox2" CssClass="ft_red"></asp:RequiredFieldValidator>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxStylerecs" Height="50px"
                    TextMode="MultiLine" Wrap="True" Width="380px" MaxLength="255"></asp:TextBox>
                <asp:RegularExpressionValidator ID="txtConclusionValidator1" ControlToValidate="TextBox2"
                    Text="Should be less then 255 Characters" ValidationExpression="^[\s\S]{1,255}$"
                    runat="server" CssClass="ft_red" />
                <br />
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label13" runat="server" CssClass="ft_black" Text="Details"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="Editor" CssClass="ft_black" Width="380" Height="200" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text="Posting Start Date"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="StartDate1" runat="server" CssClass="divdate" MaxLength="2"></asp:TextBox>
                <asp:TextBox ID="StartDate2" runat="server" CssClass="divdate" MaxLength="2"></asp:TextBox>
                <asp:TextBox ID="StartDate3" runat="server" CssClass="divdate" MaxLength="4"></asp:TextBox>
                <br />
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text="Posting End Date"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="EndDate1" runat="server" CssClass="divdate" MaxLength="2"></asp:TextBox>
                <asp:TextBox ID="EndDate2" runat="server" CssClass="divdate" MaxLength="2"></asp:TextBox>
                <asp:TextBox ID="EndDate3" runat="server" CssClass="divdate" MaxLength="4"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text="Location"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:Panel ID="CheckBoxList2" runat="server">
                    </asp:Panel>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label6" runat="server" CssClass="ft_black" Text="Contract Type"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div>
                    <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        <asp:ListItem Value="3000">Permanent</asp:ListItem>
                        <asp:ListItem Value="3001">Temporary</asp:ListItem>
                        <asp:ListItem Value="3002">Contract</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label7" runat="server" CssClass="ft_black" Text="Hours"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div>
                    <asp:CheckBoxList ID="CheckBoxList7" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        <asp:ListItem Value="3003">Full Time</asp:ListItem>
                        <asp:ListItem Value="3004">Part Time</asp:ListItem>
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label8" runat="server" CssClass="ft_black" Text="Experience"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList8" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label9" runat="server" CssClass="ft_black" Text="Categories"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:Panel ID="CheckBoxList1" runat="server">
                    </asp:Panel>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label16" runat="server" CssClass="ft_black" Text="Sectors"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:Panel ID="CheckBoxList4" runat="server">
                    </asp:Panel>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label17" runat="server" CssClass="ft_black" Text="Postcodes"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:Panel ID="CheckBoxList5" runat="server">
                    </asp:Panel>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label10" runat="server" CssClass="ft_black" Text="Salary"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList6" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <!-- salary currency -->
                <br />
                <asp:Label ID="Label38" runat="server" Text="In Currency" CssClass="ft_black"></asp:Label>
                <asp:DropDownList ID="Currency" runat="server" CssClass="dropdwn1">
                    <asp:ListItem Value="GBP" Selected="True">£ | GBP</asp:ListItem>
                    <asp:ListItem Value="USD">$ | USD</asp:ListItem>
                    <asp:ListItem Value="EUR">€ | EUR</asp:ListItem>
                    <asp:ListItem Value="CHF">CHF</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label18" runat="server" CssClass="ft_black" Text="Education"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList9" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label19" runat="server" CssClass="ft_black" Text="Career Level"></asp:Label>
            </div>
            <div class="jobformleftdiv">
                <div class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList10" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label11" runat="server" CssClass="ft_black" Text="Salary Text"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="TextBox5"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="TextboxStylerecs" MaxLength="20"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label12" runat="server" CssClass="ft_black" Text="Job Ref #"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox6"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="TextboxStylerecs" MaxLength="20"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Label ID="Label15" runat="server" CssClass="ft_black" Text="Location"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6"
                    CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            </div>
            <div class="jobformleftdiv">
                <asp:TextBox ID="TextBoxloc" runat="server" CssClass="TextboxStylerecs" MaxLength="20"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <asp:Panel ID="Panelquestion" runat="server">
            </asp:Panel>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx6">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appjobleft">
                <asp:Button ID="Button1" runat="server" CssClass="button" Text="Save &amp; Continue"
                    OnClick="Button1Click" />
            </div>
            <div class="cn_appjobleft">
            </div>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
