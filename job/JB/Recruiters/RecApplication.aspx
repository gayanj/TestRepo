<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecApplication.aspx.cs" Inherits="JB.Recruiters.RecApplication" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--load popup here-->
    <link href="/Scripts/facebox/facebox.css" media="screen" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jqueryvx.js" type="text/javascript"></script>
    <script src="/Scripts/facebox/facebox.js" type="text/javascript"></script>
    <link href="/styles/pheonixgrid.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function pageLoad(sender, args) {
            jqueryvx.js(document).ready(function ($) {
                $('a[rel*=facebox]').facebox({
                    loadingImage: '/images/loading.gif',
                    closeImage: '/images/closelabel.png'
                });
            });
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="Recruiter Applications"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <br />
    <div class="time_left">
        <div class="ft_black">
            View the candidates who applied for your jobs, a quick overview
        </div>
    </div>
    <div class="time_right">
        <div id="recapptableft">
            <!-- hook up ajax-->
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <!-- header -->
                    <div class="w10">
                        <asp:Label ID="LabelFName" runat="server" CssClass="ft_blackbd" Text="First Name"></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="LabelLName" runat="server" CssClass="ft_blackbd" Text="Last Name"></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label5" runat="server" CssClass="ft_blackbd" Text="Job Title"></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label6" runat="server" CssClass="ft_blackbd" Text="Application Date"></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label8" runat="server" CssClass="ft_blackbd" Text="Status"></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label7" runat="server" CssClass="ft_blackbd" Text="Actions"></asp:Label>
                    </div>
                    <!-- end header -->
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        OnPageIndexChanging="GridView1PageIndexChanging" CssClass="ft_black" GridLines="Horizontal"
                        BorderStyle="None" Width="100%" EmptyDataText="There are no recent applications">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div class="w10">
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("aFirstName") %>'></asp:Label>
                                    </div>
                                    <div class="w10">
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("aLastName") %>'></asp:Label>
                                    </div>
                                    <div class="w20">
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("sTitle") %>'></asp:Label>
                                    </div>
                                    <div class="w20">
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("dtentered", "{0:dd/M/yyyy}") %>'></asp:Label>
                                    </div>
                                    <div class="w10">
                                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("appstatus") %>'></asp:Label>
                                    </div>
                                    <div class="w10">
                                        <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_bluelink"
                                             NavigateUrl='<%# GetUrl(Eval("idapplications")) %>'
                                            Text="View profile" rel="facebox"></asp:HyperLink>
                                    </div>
                                    <div class="w10">
                                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# GetStatus(Eval("appstatus"), Eval("idstatus"), Eval("idapplications")) %>'
                                            Text="Change Status" CssClass="ft_bluelink"></asp:HyperLink>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle CssClass="PagerStyle" />
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
