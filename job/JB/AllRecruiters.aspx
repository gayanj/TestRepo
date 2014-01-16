<%@ Page Title="" Language="C#" MasterPageFile="~/JOB.Master" AutoEventWireup="true"
    CodeBehind="AllRecruiters.aspx.cs" Inherits="JB.Allrecruiters" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <!-- top bar -->
    <div class="divsimpletop">
        <div class="ft_whitebd">
            All Recruiters Advertizing Jobs
        </div>
    </div>
    <div class="hlp_covsrch">
        <asp:TextBox ID="Textboxrec" CssClass="TextboxSt" runat="server" placeholder="e.g. tommy"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text=" within " CssClass="ft_black"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="ft_black">
            <asp:ListItem Value="Company">Company</asp:ListItem>
            <asp:ListItem Value="Agent">Agent</asp:ListItem>
            <asp:ListItem Selected="True" Value="AllTypes">All Types</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Buttonsearch" runat="server" Text="Search" CssClass="button" OnClick="ButtonsearchClick" />
    </div>
    <div class="boxcorner">
        <!--hook up ajax-->
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div id="allrecsmid">
                    <asp:GridView ID="RecrutiersGrid" runat="server" AllowPaging="True" AutoGenerateColumns="False"
                        OnPageIndexChanging="RecrutiersGridPageIndexChanging" GridLines="None" DataKeyNames="Empid"
                        Width="400px" ShowHeader="False" OnRowDataBound="RecrutiersGridRowDataBound">
                        <Columns>
                            <asp:TemplateField>
                                <HeaderTemplate>

                                    <asp:Label ID="Label14" runat="server" Text="ALL RECRUITERS ADVERTIZING JOBS"></asp:Label>

                                </HeaderTemplate>
                                <ItemTemplate>
                                    <div class="allreccoverbrdrdiv">
                                        <div class="arecstyle50">
                                            <div class="ln_fixx8">
                                            </div>
                                            <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("srecruitername") %>'></asp:Label>

                                            &nbsp;<asp:Label ID="Label12" runat="server" CssClass="ft_black" Text="is now advertizing"></asp:Label>

                                            <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("totaljobs") %>'></asp:Label>

                                            &nbsp;<asp:Label ID="Label13" runat="server" CssClass="ft_black" Text="jobs"></asp:Label>

                                            <div class="ln_fixx4">
                                            </div>

                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Empid", "Recdetails.aspx?empid={0}") %>'
                                                Text="view recruiter profile" CssClass="ft_bluelink"></asp:HyperLink>

                                            <div class="ln_fixx1">
                                            </div>

                                            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("Empid", "jobsbyrecruiter?empid={0}") %>'
                                                Text="more jobs with this recruiter" CssClass="ft_bluelink"></asp:HyperLink>

                                            <div class="ln_fixx8">
                                            </div>
                                        </div>
                                        <div class="allrecrightimg">
                                            <div class="im_wrap1">
                                                <div class="dv_shadow000">
                                                    <asp:Image ID="recofweekimg" runat="server" CssClass="dftimgroundup wide75" ImageUrl='<%# Bind("artifact_data") %>' />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle CssClass="PagerStyle" />
                    </asp:GridView>
                    <br />
                    <br />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!-- end panel -->
        <br />
    </div>
</asp:Content>
