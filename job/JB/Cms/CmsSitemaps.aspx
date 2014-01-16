<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsSitemaps.aspx.cs" Inherits="JB.Cms.CmsSitemaps" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Sitemaps" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
      <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w40">
            <label class="ft_white">
                URL
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                TITLE
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                DESCRIPTION
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                LEVEL
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="id_sitemaps"
        GridLines="None" ID="GridView1" PageSize="20" runat="server" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w40">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("url") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("title") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("description") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("level") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("id_sitemaps", "CmsDelSitemapItem.aspx?SitemapId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink></div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("id_sitemaps", "CmsEditSitemapItem.aspx?SitemapId={0}") %>'
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