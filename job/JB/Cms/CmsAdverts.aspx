<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsAdverts.aspx.cs" Inherits="JB.Cms.CmsAllAdverts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Advertisements" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
   
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w20">
            <label class="ft_white">
                PATH
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                STATUS
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                TITLE
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                DESCRIPTION
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                URL
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                TYPE
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idtb_advertdetail"
        AllowPaging="True" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w20">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("adpath") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("astatus") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("adtitle") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("adtext") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text='<%# Bind("adurl") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label6" runat="server" CssClass="ft_black" Text='<%# Bind("adtype") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idtb_advertdetail", "CmsDelAds.aspx?Action=Activejobs&jobid={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idtb_advertdetail", "CmsEditAds.aspx?Action=Activejobs&jobid={0}") %>'
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
