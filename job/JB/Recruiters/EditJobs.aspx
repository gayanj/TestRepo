<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="EditJobs.aspx.cs" Inherits="JB.Recruiters.Editjobs" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label5" runat="server" CssClass="ft_white" Text="Edit Jobs"></asp:Label>
    </div>
    <div id="strright">
        <asp:Image ID="Image11" runat="server" ImageUrl="/images/green.png" />
        &nbsp;<asp:LinkButton ID="LinkButton4" runat="server" CssClass="ft_black" OnClick="LinkButton4Click">Active</asp:LinkButton>
        <asp:Label ID="Labelactive" runat="server" CssClass="ft_gray" Text=""></asp:Label>
        &nbsp;<asp:Image ID="Image12" runat="server" ImageUrl="/images/amber.png" />
        &nbsp;<asp:LinkButton ID="LinkButton5" runat="server" CssClass="ft_black" OnClick="LinkButton5Click">Archived</asp:LinkButton>
        <asp:Label ID="Labelarchived" runat="server" CssClass="ft_gray" Text=""></asp:Label>
        &nbsp;
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Change already posted job description here, like posting dates, description etc.
        </div>
    </div>
    <div class="time_right">
        <div id="editjobsmiddle">
            <!-- hookup ajax-->
            <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="600px" 
                        ShowHeader="False" BorderWidth="0px" AllowPaging="True" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging"
                        >
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <div id="editjobscovtop">
                                        <div class="editjobslefts">
                                            <div class="ln_fixx2">
                                            </div>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("sTitle") %>' CssClass="ft_blackbd"></asp:Label>
                                            <div class="ln_fixx2">
                                            </div>
                                            <asp:Label ID="Label6" runat="server" CssClass="ft_black" Text="Date Advertised: "></asp:Label>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("dtEnteredDate","{0:dd/M/yyyy}") %>'
                                                CssClass="ft_black"></asp:Label>
                                            &nbsp;<span class="ft_black">|</span>&nbsp;<asp:Label ID="Label7" runat="server" CssClass="ft_black" Text="Salary: "></asp:Label>
                                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("sSalaryText") %>' CssClass="ft_black"></asp:Label>
                                            &nbsp;<div class="ln_fixx2">
                                            </div>
                                            <asp:Label ID="Label2" runat="server" CssClass="ft_gray" Text='<%# Bind("sShortDescription") %>'></asp:Label>
                                            <div class="ln_fixx2">
                                            </div>
                                        </div>
                                        <div class="editjobsrights">
                                            <asp:HyperLink ID="HyperLink7" runat="server" CssClass="ft_bluelink" NavigateUrl='<%#  GetUrl(Eval("idJobs")) %>'>Edit</asp:HyperLink>
                                        </div>
                                    </div>
                                    <div class="dv_fix">
                                    </div>
                                    <div class="ln_fixx2">
                                    </div>
                                    <div class="ln_ccc">
                                    </div>
                                    <div class="ln_fixx2">
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle CssClass="PagerStyle" />
                    </asp:GridView>
                    <div class="ln_fixx10">
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
