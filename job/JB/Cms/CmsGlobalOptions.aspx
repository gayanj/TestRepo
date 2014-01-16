<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsGlobalOptions.aspx.cs" Inherits="JB.Cms.Cmsglobaloptions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Global Options" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
   
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w80">
            <label class="ft_white">
                KPI NAME
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                KPI VALUE
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>
    <asp:GridView ID="GridView1" runat="server" CellPadding="3" GridLines="None" AutoGenerateColumns="False"
        DataKeyNames="idtb_cpanel" AllowPaging="True" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w80">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("kpiname") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("kpivalue") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idtb_cpanel", "CmsEditGlobalOption.aspx?OptionId={0}") %>'
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
