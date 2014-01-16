<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsSiteSearch.aspx.cs" Inherits="JB.Cms.CmsSiteIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Site Search Index" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
       <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w20">
            <label class="ft_white">
                TITLE
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                URL
            </label>
        </div>
        <div class="w40">
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

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_sitesearch"
        AllowPaging="True" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w20">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("titles") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("url") %>'></asp:Label>
                    </div>
                    <div class="w40">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("description") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("dtentered","{0:d}") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("id_sitesearch", "CmsDelSiteSearch.aspx?SearchId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink></div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("id_sitesearch", "CmsEditSiteSearch.aspx?SearchId={0}") %>'
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