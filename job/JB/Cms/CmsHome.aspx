<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsHome.aspx.cs" Inherits="JB.Cms.Cmshome" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="CMS Home" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="260px">
    </rsweb:ReportViewer>

    <!-- trackers -->
    <div class="dv_fix"></div>
    <div class="ln_dotccc">
    </div>
    <div class="ux_gridheader">
        <div class="w90">
            <label class="ft_white">
                URL
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                VIEWS
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView AllowPaging="True" AutoGenerateColumns="False"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="10" runat="server" Width="100%">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w90">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("entryurl") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("views") %>'></asp:Label>
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

    <!-- country tracking -->
    <div class="dv_fix"></div>
    <div class="ln_dotccc">
    </div>
    <div class="ux_gridheader">
        <div class="w90">
            <label class="ft_white">
                COUNTRY
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                VIEWS
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView AllowPaging="True" AutoGenerateColumns="False"
        GridLines="None" ID="GridView2" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="10" runat="server" Width="100%">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w90">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("visitorcountry") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("views") %>'></asp:Label>
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
