<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsHomePageLinks.aspx.cs" Inherits="JB.Cms.CmsHomePageLinks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Home Page Links" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w30">
            <label class="ft_white">
                LINK NAME
            </label>
        </div>
        <div class="w30">
            <label class="ft_white">
                URL
            </label>
        </div>
        <div class="w30">
            <label class="ft_white">
                IMAGE URL
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView ID="GridView1" runat="server" CellPadding="3" GridLines="Vertical"
        AutoGenerateColumns="False" DataKeyNames="id_headerlinks" AllowPaging="True"
        PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w30">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("hlinkname") %>'></asp:Label>
                    </div>
                    <div class="w30">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("hlinktexturl") %>'></asp:Label>
                    </div>
                    <div class="w30">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("hlinkimgurl") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("id_headerlinks", "CmsDelSiteLink.aspx?LinkId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("id_headerlinks", "CmsEditSiteLink.aspx?LinkId={0}") %>'
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
