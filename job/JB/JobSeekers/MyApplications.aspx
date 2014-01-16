<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="MyApplications.aspx.cs" Inherits="JB.Jobseekers.Myapplications" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="Applications Made"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Keep track of applications you made and get notified as soon as the recruiter makes
            an update</div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <!-- hook up ajax-->
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                        OnPageIndexChanging="GridView1PageIndexChanging" ShowHeader="False">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="myappbreak wrap justify">
                                        <asp:Label ID="Label5" runat="server" Text="Applied for" CssClass="ft_blackbd"></asp:Label>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("sTitle") %>' CssClass="ft_black"></asp:Label>
                                        <asp:Label ID="Label6" runat="server" Text=" on " CssClass="ft_blackbd"></asp:Label>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("dtEntered") %>' CssClass="ft_black"></asp:Label>
                                        <asp:Label ID="Label7" runat="server" Text=" to work for " CssClass="ft_blackbd"></asp:Label>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("sRecruiterName") %>' CssClass="ft_black"></asp:Label>
                                        <asp:Label ID="Label8" runat="server" Text=" and currently " CssClass="ft_blackbd"></asp:Label>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Applicationstatus") %>' CssClass="ft_black"></asp:Label>
                                        <div class="ln_ccc">
                                        </div>
                                    </div>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" CssClass="ft_blackbd" />
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle CssClass="PagerStyle" />
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <br />
</asp:Content>