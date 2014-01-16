<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JobsByRecruiter.aspx.cs" Inherits="JB.Jobsbyrecruiter" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv4.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
         
        <asp:Label ID="Label1" runat="server" CssClass="ft_whitebd" Text="all jobs from this recruiter"></asp:Label>
         
    </div>
    <div class="boxcorner">
        <div class="ln_fixx8">
        </div>
        <div class="dv_fix">
        </div>
        <div id="wrapjobsbyrectop">
            <div id="wrapjobsbyrecleft">
                <asp:GridView ID="Gridjobsbyrec" Width="400px" GridLines="None" AutoGenerateColumns="false"
                    AllowPaging="true" runat="server" ShowHeader="false" OnPageIndexChanging="GridjobsbyrecPageIndexChanging"
                    OnRowDataBound="GridjobsbyrecRowDataBound">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <br />
                                <div class="jobbyrecleft">
                                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# String.Format("jobdetails?jobid={0}&jobtitle={1}", Eval("idjobs"), Eval("sTitle")).Replace(" ", "-").Replace("--", "-").Replace("--", "-") %>'
                                        CssClass="ft_blueh1" Text='<%# Bind("sTitle") %>'></asp:HyperLink>
                                    <div class="ln_fixx4">
                                    </div>
                                    <div class="ft_gray">
                                         
                                        <asp:Label ID="Labeldadvert" runat="server" Text="Posted:"></asp:Label>
                                         
                                        <asp:Label ID="Labeldadvertout" runat="server" Text='<%# Bind("dtEnteredDate","{0:dd/M/yyyy}") %>'></asp:Label>
                                         
                                        <asp:Label ID="Label12" runat="server" Text=" | Salary:"></asp:Label>
                                         
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("sSalaryText") %>'></asp:Label>
                                         
                                        <asp:Label ID="Label5" runat="server" Text=" | Location:"></asp:Label>
                                         
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("slocation") %>'></asp:Label>
                                    </div>
                                    <div class="ln_fixx4">
                                    </div>
                                    <asp:Label ID="Label2" runat="server" CssClass="ft_gray444" Text='<%# Bind("sShortDescription") %>'></asp:Label>
                                    <div class="ln_fixx4">
                                    </div>
                                     
                                    <asp:HyperLink ID="HyperLink4" runat="server" CssClass="ft_blacklink" NavigateUrl='<%# String.Format("jobdetails?jobid={0}&jobtitle={1}", Eval("idjobs"), Eval("sTitle")).Replace(" ", "-").Replace("--", "-").Replace("--", "-") %>'
                                        Text="Apply"></asp:HyperLink>
                                     
                                    <div class="dv_fix">
                                    </div>
                                    <br />
                                </div>
                                <div class="ln_ccc">
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerStyle CssClass="PagerStyle" />
                </asp:GridView>
                <br />
            </div>
            <div id="wrapjobsbyrecright">
                <br />
                <div class="im_wrap1">
                    <div class="dv_shadow000">
                        <asp:Image ID="aartifactdata" runat="server" Width="75px" Height="75px" />
                    </div>
                </div>
                <br />
                <asp:Label ID="rTitle" runat="server" CssClass="ft_blackbd" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:Label ID="rDescription" runat="server" CssClass="ft_black" Text="Label"></asp:Label>
                <br />
                <br />
                <asp:HyperLink ID="rWebsite" runat="server" CssClass="ft_bluelink"></asp:HyperLink>
                <br />
                <asp:Label ID="rCountry" runat="server" CssClass="ft_black" Text="Label"></asp:Label>
                <br />
                <br />
            </div>
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_fixx8">
        </div>
    </div>
</asp:Content>
