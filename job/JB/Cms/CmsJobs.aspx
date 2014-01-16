<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsJobs.aspx.cs" Inherits="JB.Cms.CmsJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Labelheaddetail" runat="server" Text="Active Jobs" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w60">
            <label class="ft_white">JOB TITLE</label>
        </div>
        <div class="w10">
            <label class="ft_white">
                ENTRY DATE
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                REF NO.
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                STATUS
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idjobs"
        AllowPaging="True" PageSize="20"
        OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w60">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("stitle") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind ("dtEntereddate", "{0:d}") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("sRef") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("actives") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idjobs", "CmsDelJobs.aspx?JobId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idjobs", "CmsEditJobs.aspx?JobId={0}") %>'
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
