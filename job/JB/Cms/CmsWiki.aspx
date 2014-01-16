<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsWiki.aspx.cs" Inherits="JB.Cms.CmsWiki" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="How to Use CMS" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w10">
            <label class="ft_white">
                ID
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                WIKI TITLE
            </label>
        </div>
        <div class="w50">
            <label class="ft_white">
                DESCRIPTION
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                ENTERED
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idtb_wikis"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="10" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("idtb_wikis") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("t_wikititle") %>'></asp:Label>
                    </div>
                    <div class="w50">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("t_wikidescription") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text='<%# Bind("dtentered","{0:d}") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idtb_wikis", "CmsDelWiki.aspx?WikiId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idtb_wikis", "CmsEditWiki.aspx?WikiId={0}") %>'
                            Text="Edit" CssClass="ft_bluelink"></asp:HyperLink>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_dotted">
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerStyle CssClass="PagerStyle" />
    </asp:GridView>

</asp:Content>
