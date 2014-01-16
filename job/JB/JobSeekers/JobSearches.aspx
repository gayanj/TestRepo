<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="JobSearches.aspx.cs" Inherits="JB.Jobseekers.Jobsearches" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="Recent Searches"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Quickly browse through jobs, don't have to remember those searches, just click and
            go
        </div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <!-- hook up ajax-->
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="searchlist" runat="server" AutoGenerateColumns="False" ShowHeader="False"
                        AllowPaging="True" OnPageIndexChanging="SearchlistPageIndexChanging">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text="You saved a search with name " CssClass="ft_black"></asp:Label>
                                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# LoadSearch(Eval("sid"),Eval("searchtext")) %>'
                                        CssClass="ft_blueh1" Text='<%# Bind("sdefinition") %>'></asp:HyperLink>
                                    <asp:Label ID="Label3" runat="server" Text=" on " CssClass="ft_black"></asp:Label>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("dtentered","{0:dd/M/yyyy}") %>'
                                        CssClass="ft_blackbd"></asp:Label>
                                    <asp:Label ID="Label5" runat="server" Text=" at " CssClass="ft_black"></asp:Label>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("dtentered","{0:f}") %>' CssClass="ft_blackbd"></asp:Label>
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
