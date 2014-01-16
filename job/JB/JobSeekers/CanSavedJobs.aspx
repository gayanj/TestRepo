<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="CanSavedJobs.aspx.cs" Inherits="JB.Jobseekers.Cansavedjobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="Saved Jobs"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Jobs which you have bookmarked recently for use later</div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <!-- hook up ajax-->
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="searchjoblist" runat="server" AutoGenerateColumns="False" ShowHeader="False"
                        AllowPaging="True" OnPageIndexChanging="SearchjoblistPageIndexChanging">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# Eval("idjobs", "/jobdetails?jobid={0}") %>'
                                        CssClass="ft_blueh1" Text='<%# Myjob(Eval("jobtitle")) %>'></asp:HyperLink>
                                    <asp:Label ID="Label2" runat="server" Text=" posted by " CssClass="ft_black"></asp:Label>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("company") %>' CssClass="ft_blackbd"></asp:Label>
                                    <asp:Label ID="Label4" runat="server" Text=" on " CssClass="ft_black"></asp:Label>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("posteddate","{0:dd/M/yyyy}") %>'
                                        CssClass="ft_blackbd"></asp:Label>
                                    <asp:Label ID="Label8" runat="server" Text=" & you saved it on " CssClass="ft_black"></asp:Label>
                                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("createddate","{0:dd/M/yyyy}") %>'
                                        CssClass="ft_blackbd"></asp:Label>
                                    <div class="ln_ccc">
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle CssClass="PagerStyle" />
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>