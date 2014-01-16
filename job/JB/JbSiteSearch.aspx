<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbSiteSearch.aspx.cs" Inherits="JB.Jbsitesearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
     
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Complete Site Search</div>
    </div>
    <div class="hlp_covsrch">
        <asp:TextBox ID="TextBox1" runat="server" placeholder="e.g. candidate login" CssClass="TextboxSt"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search Entire Site" CssClass="button"
            OnClick="Button1Click" />
    </div>
     
    <div class="boxcorner">
        <div class="dvleft">
            <asp:GridView ID="SearchResult" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                OnPageIndexChanging="SearchResultPageIndexChanging" OnRowDataBound="SearchResult_RowDataBound">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="jbsitesearchgrid">
                                <div class="ln_fixx4">
                                </div>
                                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# GetUrl(Eval("url")) %>'
                                    CssClass="ft_graybd" Text='<%# Bind("titles") %>'></asp:HyperLink>
                                <br />
                                <asp:Label ID="Labeldadvertout" runat="server" CssClass="ft_gray" Text='<%# Bind("description") %>'></asp:Label>
                                <br />
                                <asp:Label runat="server" ID="purl" CssClass="ft_gray" Text="Linked URL:"></asp:Label>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# GetUrl(Eval("url")) %>'
                                    CssClass="ft_blueh1" Text='<%# GetUrl(Eval("url")) %>'></asp:HyperLink>
                                <div class="ln_fixx4">
                                </div>
                                <div class="ln_ccc">
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle CssClass="PagerStyle" />
            </asp:GridView>
        </div>
        <div class="dv_fix">
        </div>
        <br />
    </div>
</asp:Content>
