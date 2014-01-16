<%@ Page AutoEventWireup="true" CodeBehind="CmsHeaders.aspx.cs" Inherits="JB.Cms.Cmsheaders"
    Language="C#" MasterPageFile="~/Cms/Cms.Master" Title="" %>

<asp:Content ContentPlaceHolderID="head" ID="Content1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Site Headers" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
     <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w20">
            <label class="ft_white">
                SEO NAME
            </label>
        </div>
        <div class="w70">
            <label class="ft_white">
                SEO DESCRIPTION
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idtb_seo"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="10" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w20">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("seo_name") %>'></asp:Label>
                    </div>
                    <div class="w70">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("seo_description") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idtb_seo", "CmsDelHeaderItem.aspx?HeaderId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink"></asp:HyperLink>
                    </div>
                    
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idtb_seo", "CmsEditHeaderItem.aspx?HeaderId={0}") %>'
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
