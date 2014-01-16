<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsRecruiters.aspx.cs" Inherits="JB.Cms.CmsAllrecruiters" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="All Recruiters" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>

    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w10">
            <label class="ft_white">
                REC ID
            </label>
        </div>
        <div class="w40">
            <label class="ft_white">
                RECRUITER NAME
            </label>
        </div>
        <div class="w30">
            <label class="ft_white">
                WEBSITE
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                ACTIVE
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>


    <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="False"
        DataKeyNames="empid" AllowPaging="True" PageSize="10" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w10">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("empid") %>'></asp:Label>
                    </div>
                    <div class="w40">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("srecruitername") %>'></asp:Label>
                    </div>
                    <div class="w30">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("swebsite") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text='<%# Bind("sisactive") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("empid", "CmsDelUser.aspx?EmpId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("empid", "CmsEditUser.aspx?EmpId={0}") %>'
                            Text="Edit" CssClass="ft_bluelink"></asp:HyperLink>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label6" runat="server" CssClass="ft_black" Text="Email :-" ></asp:Label>
                    </div>
                    <div class="w90">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("semailaddress") %>'></asp:Label>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_dotted">
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
