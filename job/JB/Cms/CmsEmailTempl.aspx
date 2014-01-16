<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsEmailTempl.aspx.cs" Inherits="JB.Cms.CmsShowEmailTempl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="All Email Templates" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>    
     <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w20">
            <label class="ft_white">
                HEADER
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                FOOTER
            </label>
        </div>
        <div class="w40">
            <label class="ft_white">
                DESCRIPTION
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                CHECK ID
            </label>
        </div>        
    </div>
    <div class="dv_fix"></div>
    
    <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idemailtemplates"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="20" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w20">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("eheader") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("efooter") %>'></asp:Label>
                    </div>
                    <div class="w40">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("edescription") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("etemplatechkid") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idemailtemplates", "CmsDelETemplate.aspx?TemplateId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idemailtemplates", "CmsEditETemplate.aspx?TemplateId={0}") %>'
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
