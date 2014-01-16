<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbSubscribe.aspx.cs" Inherits="JB.Jbsubscribe" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <link href="/styles/autocomplete.css" rel="stylesheet" type="text/css" />
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
    <link href="/styles/pheonixv6.css" rel="stylesheet" type="text/css" />    
    <link href="/styles/jquery.jscrollpane.css" type="text/css" rel="stylesheet" media="all" />
    <script src="/scripts/scrollv11.js" type="text/javascript"></script>
    <script src="/scripts/scrollv12.js" type="text/javascript"></script>
    <script src="/scripts/scrollv13.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Subscription in progress
        </div>
    </div>
    <div class="boxcorner">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
            <Services>
                <asp:ServiceReference Path="~/autosearchpcode.asmx" />
            </Services>
        </asp:ScriptManager>
        <br />
        <div class="dv_fix">
        </div>
         
        <div class="jbsubscribe_mid">
            <div id="setbox">
                <div class="ft_notify">
                    <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_fixx4">
                </div>
                <div class="ft_black">
                    <img alt="one" src="/images/nm_one.gif" />&nbsp; Please make a selection for email
                    alerts
                </div>
                <br />
                <div id="dvleftpanels1">
                    <!-- div for Categories-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Categories
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltindustry" class="scroll-pane">
                        <asp:Panel ID="CheckBoxList1" runat="server">
                        </asp:Panel>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Sectors
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltsector" class="scroll-pane">
                        <asp:Panel ID="CheckBoxList7" runat="server">
                        </asp:Panel>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <!-- div for location-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Location
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltlocation" class="scroll-pane">
                        <asp:Panel ID="CheckBoxList2" runat="server">
                        </asp:Panel>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <!-- div for postcodes-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Postcodes
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltpostcodes">
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="jb_subscribeleft">
                                    <asp:TextBox ID="TextBoxAutopop" CssClass="pcodedynatextbx" runat="server"></asp:TextBox>
                                    <asp:TextBoxWatermarkExtender ID="TextBoxAutopop_TWE" runat="server" Enabled="True"
                                        TargetControlID="TextBoxAutopop" WatermarkCssClass="pcodedynatextbxtwe" WatermarkText="type a postcode & hit enter key">
                                    </asp:TextBoxWatermarkExtender>
                                    <asp:AutoCompleteExtender ID="searchtext_AutoCompleteExtender1" runat="server" TargetControlID="TextBoxAutopop"
                                        ServicePath="autosearchpcode.asmx" CompletionListCssClass="po_litop" CompletionListItemCssClass="po_lilist"
                                        CompletionListHighlightedItemCssClass="po_liselect" ServiceMethod="GetCompletionList"
                                        MinimumPrefixLength="1" CompletionInterval="1000" EnableCaching="false" CompletionSetCount="10">
                                    </asp:AutoCompleteExtender>
                                </div>
                                <div class="jplus_left">
                                    <asp:Button ID="AddPostCodes" runat="server" Text="" CausesValidation="false" CssClass="btn_subs"
                                        OnClick="Dybtnclickb2" />
                                </div>
                                <asp:Panel ID="CheckBoxList8" runat="server">
                                </asp:Panel>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <div class="dv_fix">
                    </div>
                </div>
                <div id="dvleftpanels2">
                    <!-- div for salary range-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Salary Range
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltsalary" class="scroll-pane">
                        <asp:CheckBoxList ID="CheckBoxList6" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        </asp:CheckBoxList>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <!-- div for contract-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Contract type
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltcontract" class="scroll-pane">
                        <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        </asp:CheckBoxList>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <!-- div for career-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Career Level
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltcareer" class="scroll-pane">
                        <asp:CheckBoxList ID="CheckBoxList10" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        </asp:CheckBoxList>
                    </div>
                    <div class="divheightsrch">
                    </div>
                </div>
                <div id="dvleftpanels3">
                    <!-- div for hours-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Hours
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvlthours" class="scroll-pane">
                        <asp:CheckBoxList ID="CheckBoxList4" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        </asp:CheckBoxList>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <!-- div for employer-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Experience
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvltemployer" class="scroll-pane">
                        <asp:CheckBoxList ID="CheckBoxList5" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        </asp:CheckBoxList>
                    </div>
                    <div class="divheightsrch">
                    </div>
                    <!-- div for education level-->
                    <div class="dv_fix">
                    </div>
                    <div class="tb_headone">
                        Education
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_444">
                    </div>
                    <div class="ln_fixx2">
                    </div>
                    <div id="dvlteducation" class="scroll-pane">
                        <asp:CheckBoxList ID="CheckBoxList9" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                        </asp:CheckBoxList>
                    </div>
                    <div class="divheightsrch">
                    </div>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ft_black">
                <img alt="two" src="/images/nm_two.gif" />
                What frequency you want to receive emails on?
                <div class="ln_fixx4">
                </div>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal"
                    RepeatLayout="Flow">
                    <asp:ListItem Value="0" Enabled="False">Weekly</asp:ListItem>
                    <asp:ListItem Value="1" Selected="True">Monthly</asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div>
                <div class="dv_fix">
                </div>
                <br />
                <div class="ft_black">
                    <img alt="three" src="/images/nm_three.gif" />
                    What is your prefered email format?
                    <div class="ln_fixx4">
                    </div>
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal"
                        RepeatLayout="Flow">
                        <asp:ListItem Value="0">Plain Text</asp:ListItem>
                        <asp:ListItem Value="1" Selected="True">HTML</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="dv_fix">
                </div>
                <br />
                <div class="ft_black">
                    <img alt="four" src="/images/nm_four.gif" />&nbsp; Please enter your email Address
                    to create a job alert
                </div>
                <br />
                <div id="dvleftpanels4">
                    <asp:TextBox ID="Emailsubs" CssClass="TextboxSt" runat="server" Width="200px"></asp:TextBox>
                    <asp:TextBoxWatermarkExtender ID="Emailsubs_TWE" runat="server" Enabled="True" TargetControlID="Emailsubs"
                        WatermarkCssClass="TextboxSttwe" WatermarkText="like someone@example.com">
                    </asp:TextBoxWatermarkExtender>
                    <asp:Button ID="Button1" runat="server" Text="Subscribe" CssClass="button" OnClick="Button1Click" />
                </div>
            </div>
            <div class="dv_fix">
                <br />
                <br />
            </div>
        </div>
         
    </div>
</asp:Content>
