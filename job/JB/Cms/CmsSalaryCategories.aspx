<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsSalaryCategories.aspx.cs" Inherits="JB.Cms.Cmssalarycategories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Salary Categories" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w90">
            <label class="ft_white">
                OCCUPATION CATEGORY
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>

    <asp:GridView ID="GridView1" runat="server" GridLines="None" Width="100%" AutoGenerateColumns="False"
        DataKeyNames="idsalaryoccupations" AllowPaging="True" PageSize="20" OnPageIndexChanging="GridView1_PageIndexChanging"
        OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting"
        OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w90">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("occupationname") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idsalaryoccupations", "CmsDelSalary.aspx?SalId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idsalaryoccupations", "CmsEditSalary.aspx?SalId={0}") %>'
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
