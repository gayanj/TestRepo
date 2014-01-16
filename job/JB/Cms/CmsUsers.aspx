<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsUsers.aspx.cs" Inherits="JB.Cms.Cmsallusers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="All Users" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>

    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w20">
            <label class="ft_white">
                ID USERS
            </label>
        </div>
        <div class="w30">
            <label class="ft_white">
                USER NAME
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                FIRST NAME
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                LAST NAME
            </label>
        </div>
    </div>

    <div class="dv_fix"></div>

    <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="False"
        DataKeyNames="idusers" AllowPaging="True" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w20">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("idusers") %>'></asp:Label>
                    </div>
                    <div class="w30">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("uusername") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("ufirstname") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("ulastname") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idusers", "CmsDelUser.aspx?UserId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink></div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idusers", "CmsEditUser.aspx?UserId={0}") %>'
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