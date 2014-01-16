<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsHelpCat.aspx.cs" Inherits="JB.Cms.CmsHelpCat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Help Categories" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
      <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w10">
            <label class="ft_white">
                ID CAT
            </label>
        </div>
        <div class="w80">
            <label class="ft_white">
                CATEGORY
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
      <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="hcatid"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="10" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("hcatid") %>'></asp:Label>
                    </div>
                    <div class="w80">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("cdefinition") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("hcatid", "CmsDelHelpCategory.aspx?CategoryId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink></div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("hcatid", "CmsEditHelpCategory.aspx?CategoryId={0}") %>'
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