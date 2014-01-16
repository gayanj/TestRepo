<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsSiteTitles.aspx.cs" Inherits="JB.Cms.Cmsbrandtitles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Site Titles" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
     <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w90">
            <label class="ft_white">
                BRANDING TITLE
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView ID="GridView1" runat="server" CellPadding="3" GridLines="Vertical"
        AutoGenerateColumns="False" DataKeyNames="idtb_branding" AllowPaging="True" PageSize="20"
        OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w90">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("kpivalue") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idtb_branding", "CmsEditSiteTitles.aspx?BrandingId={0}") %>'
                            Text="Edit" CssClass="ft_bluelink">
                        </asp:HyperLink>
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