<%@ Page AutoEventWireup="true" CodeBehind="CmsUserModeration.aspx.cs" Inherits="JB.Cms.Cmsusermoderation"
    Language="C#" MasterPageFile="~/Cms/Cms.Master" Title="" %>

<asp:Content ContentPlaceHolderID="head" ID="Content1" runat="server">
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="Content2" runat="server">
    <asp:Label CssClass="ft_cmsheading1" ID="Labelheaddetail" runat="server" Text="User Moderation Requests"></asp:Label>
    <div class="ln_dotccc"></div>

    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w10">
            <label class="ft_white">
                ID USERS
            </label>
        </div>

         <div class="w20">
            <label class="ft_white">
                REQUEST DATE
            </label>
        </div>

         <div class="w60">
            <label class="ft_white">
                DETAILS
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>

    <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idtb_usermoderation"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting"
        OnRowEditing="GridView1_RowEditing" PageSize="20" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("idusers") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("dtrequested","{0:d}") %>'></asp:Label>
                    </div>
                    <div class="w60">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("sdefinition") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idtb_usermoderation", "CmsDelModeration.aspx?RequestId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idtb_usermoderation", "CmsEditModeration.aspx?RequestId={0}") %>'
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
