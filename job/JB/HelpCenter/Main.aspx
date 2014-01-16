<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="Main.aspx.cs" Inherits="JB.Helpcenter.Main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Help Center
        </div>
    </div>
    <div class="hlp_covsrch">
        <asp:TextBox ID="Textboxqs" CssClass="TextboxSt" runat="server" placeholder="e.g. privacy"></asp:TextBox>
        <asp:Button ID="Buttonsearch" runat="server" Text="Search" CssClass="button" OnClick="ButtonsearchClick" />
    </div>
    <div class="boxcorner">
        <asp:Label ID="Label2" runat="server" CssClass="ft_backhighh1" Text="Get answers to your most frequently asked questions here, either they relate to a job or our sites."></asp:Label>
        <br />
        <br />
        <div class="hlp_ansheader">
            <asp:Label ID="Label1" runat="server" CssClass="ft_blackbd" Text="Browse by Category"></asp:Label>
        </div>
        <div class="hlp_ansl1">
            <asp:DataList ID="browecategories" runat="server">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("hcatid") %>'
                        CssClass="ft_bluelink" OnClick="LinkButton3Click" Text='<%# Eval("category") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div class="hlp_ansl2">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnableViewState="false" ScriptMode="Release">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="Gridviewanswers" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        GridLines="None" OnPageIndexChanging="GridviewanswersPageIndexChanging" BorderStyle="None"
                        ShowHeader="False">
                        <Columns>
                            <asp:TemplateField HeaderText="Question">
                                <ItemTemplate>
                                    <img alt="bullet" src="/images/menu_arrow.gif" />
                                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_bluelink" NavigateUrl='<%# Eval("idtb_helpcenterqs", "answer.aspx?qid={0}") %>'
                                        Text='<%# Eval("Question") %>'></asp:HyperLink>
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