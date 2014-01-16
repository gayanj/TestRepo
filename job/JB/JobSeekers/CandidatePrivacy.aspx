<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="CandidatePrivacy.aspx.cs" Inherits="JB.Jobseekers.Candidateprivacy" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/autocomplete.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label1" runat="server" Text="Privacy Settings" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Please check the sections you <b>DO NOT</b> want recruiters to see on your profile</div>
    </div>
    <div class="time_right">
        <div class="cn_privmid">
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                First Name</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="firstname" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Last Name</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="lastname" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Address1</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="address1" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Address2</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="address2" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Address3</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="address3" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Town</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="town" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                County</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="county" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Country</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="country" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                PostCode</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="postcode" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Home Phone</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="homephone" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--nametag -->
            <div class="cn_privstyle">
                Work Phone</div>
            <div class="cn_privstyle">
                <asp:CheckBox ID="workphone" runat="server" /></div>
            <div class="ln_fixx4">
            </div>
            <div class="dv_fix">
            </div>
            <!--hookup ajax -->
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
                <Services>
                    <asp:ServiceReference Path="autosearchrec.asmx" />
                </Services>
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <!--blocked recs-->
                    <div class="ln_fixx6">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="ln_fixx6">
                    </div>
                    <div class="cn_blockreclabel">
                        Block Recruiters</div>
                    <div>
                        <asp:TextBox ID="recprivtext" CssClass="cn_txtbox" runat="server" MaxLength="100"></asp:TextBox>
                        <asp:AutoCompleteExtender ID="searchtext_AutoCompleteExtender" runat="server" TargetControlID="recprivtext"
                            ServicePath="/autosearchrec.asmx" CompletionListCssClass="ac_rclitop" CompletionListItemCssClass="ac_rclilist"
                            CompletionListHighlightedItemCssClass="ac_rcliselect" ServiceMethod="GetCompletionList"
                            MinimumPrefixLength="1" CompletionInterval="100" EnableCaching="true" CompletionSetCount="10">
                        </asp:AutoCompleteExtender>
                        <asp:Button ID="addpriv" runat="server" CssClass="button" Text="Add" OnClick="AddprivClick" />
                        <br />
                        <asp:Label ID="blocknotify" CssClass="ft_red" runat="server" Text="Recruiter already blocked"
                            Visible="False"></asp:Label>
                        <div class="ln_fixx6">
                        </div>
                        <div class="ln_ccc">
                        </div>
                        <div class="ln_fixx6">
                        </div>
                    </div>
                    <asp:GridView ID="recpriv" ShowHeader="False" runat="server" DataKeyNames="empid"
                        AutoGenerateColumns="False" Width="400px" BorderWidth="0px" OnRowCommand="RecprivRowCommand"
                        GridLines="None" EmptyDataText="No recruiters blocked!">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div>
                                        <asp:Label ID="Label1" Width="80%" CssClass="ft_black" runat="server" Text='<%# Bind("sRecruitername") %>'></asp:Label>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="ft_bluelink" CommandName="Click"
                                            CommandArgument='<%#Eval("empid") %>'>Unblock</asp:LinkButton>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EmptyDataRowStyle CssClass="ft_black" />
                    </asp:GridView>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_fixx6">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="ln_fixx6">
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="cn_appdvright">
                        <asp:Button ID="btsave" runat="server" Text="Save" CssClass="button" OnClick="BtsaveClick" />&nbsp;<asp:Button
                            ID="btcancel" runat="server" Text="Cancel" CssClass="button" OnClick="BtcancelClick" />
                        <div class="ln_fixx4">
                        </div>
                        <div class="ln_fixx4">
                        </div>
                    </div>
                    <div class="dv_fix">
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
            <div class="dv_fix">
            </div>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>