<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsArticles.aspx.cs" Inherits="JB.Cms.CmsShowArticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="All Articles" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
   
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w10">
            <label class="ft_white">
                ID ARTICLES
            </label>
        </div>
        <div class="w40">
            <label class="ft_white">
                TITLE
            </label>
        </div>
        <div class="w30">
            <label class="ft_white">
                URL
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                ENTERED
            </label>
        </div>

    </div>
    <div class="dv_fix"></div>

    <asp:GridView ID="GridArticles" runat="server" GridLines="None" AutoGenerateColumns="False"
        DataKeyNames="id_articles" AllowPaging="True" PageSize="20" OnPageIndexChanging="GridArticles_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w10">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("id_articles") %>'></asp:Label>
                    </div>
                    <div class="w40">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("Articlename") %>'></asp:Label>
                    </div>
                    <div class="w30">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("Articleurl") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text='<%# Bind("dtentered","{0:d}") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("id_articles", "CmsDelArticle.aspx?ArticleId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("id_articles", "CmsEditArticle.aspx?ArticleId={0}") %>'
                            Text="Edit" CssClass="ft_bluelink"></asp:HyperLink>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_dotted">
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
