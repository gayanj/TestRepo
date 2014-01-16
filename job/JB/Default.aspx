<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="JB.Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel='alternate' type='application/rss+xml' title='RSS' href='http://v1.fashionquadrant.com/jobsrss' />
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <link href="/styles/autocomplete.css" rel="stylesheet" type="text/css" />
    <script src="/scripts/dragon0.js" type="text/javascript"></script>
    <link href="/styles/pheonixv5.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="/styles/jquery.jscrollpane.css" rel="stylesheet" media="all" />
    <script src="/scripts/scrollv11.js" type="text/javascript"></script>
    <script src="/scripts/scrollv12.js" type="text/javascript"></script>
    <script src="/scripts/scrollv13.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
        <Services>
            <asp:ServiceReference Path="~/autosearchjob.asmx" />
        </Services>
    </asp:ScriptManager>
    <div class="boxcorner">
        <div class="dv_fix">
        </div>        
        <div id="mainpgsleft">
            <div id="mn_covsrch">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:TextBox ID="searchtext" CssClass="dfttbsearchbx" AutoCompleteType="None" runat="server"
                         Text="e.g. designer, manager"  MaxLength="255"></asp:TextBox>
                         <asp:TextBoxWatermarkExtender ID="searchtext_TWE" runat="server" Enabled="True" TargetControlID="searchtext"
                            WatermarkCssClass="dfttbsearchbxwme" WatermarkText="e.g. designer, manager">
                        </asp:TextBoxWatermarkExtender>
                          <asp:AutoCompleteExtender ID="searchtext_AutoCompleteExtender" runat="server" TargetControlID="searchtext"
                            ServicePath="autosearchjob.asmx" CompletionListCssClass="ac_litop" CompletionListItemCssClass="ac_lilist"
                            CompletionListHighlightedItemCssClass="ac_liselect" ServiceMethod="GetCompletionList"
                            MinimumPrefixLength="1" CompletionInterval="1000" EnableCaching="true" CompletionSetCount="10">
                        </asp:AutoCompleteExtender>

                        <div class="dv_fix">
                        </div>
                        <div class="searchedl3">
                            <asp:Button ID="DefButton1" CssClass="button" runat="server" Text="Search" OnClick="SearchbuttonClick" />
                        </div>
                        <div class="searchedl3">
                            <asp:CheckBox ID="TargetCurrent" runat="server" CssClass="bigcheckbox" Text="Target Current Location" />
                        </div>
                        <%--<div class="sr_progind1">
                            <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel1"
                                DisplayAfter="1">
                                <ProgressTemplate>
                                    <asp:Image ID="Image11" runat="server" ImageUrl="/images/loaders.gif" />
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>--%>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <br />
            <!-- top tabs -->
            <div id="maintbwidth1">
                <div id="tbind" class="tb_headfourselected" onclick="hidedivs('saldiv');hidedivs('locdiv');showdivs('inddiv');setActiveTab('tbind');"
                    onmouseover="settabova('tbind');">
                    <asp:Label ID="Label7" runat="server" Text="Label">Categories</asp:Label>
                </div>
                <div id="tbloc" class="tb_headfour" onclick="hidedivs('saldiv');hidedivs('inddiv');showdivs('locdiv');setActiveTab('tbloc');"
                    onmouseover="settabova('tbloc');">
                    <asp:Label ID="Label9" runat="server" Text="Label">Locations</asp:Label>
                </div>
                <div id="tbsal" class="tb_headfour" onclick="hidedivs('inddiv');hidedivs('locdiv');showdivs('saldiv');setActiveTab('tbsal');"
                    onmouseover="settabova('tbsal');">
                    <asp:Label ID="Label10" runat="server" Text="Label">Salary</asp:Label>
                </div>
            </div>
            <!-- details -->
            <div id="inddiv" class="scroll-pane">
                <div class="introundupdiv">
                    <asp:DataList ID="Industrylist" runat="server" RepeatColumns="2" RepeatLayout="Flow">
                        <ItemTemplate>
                            <div class="gr_tabdesc">
                                <img alt="bullet" src="/images/img_bull.gif" />
                                <asp:LinkButton ID="Linkindustry" runat="server" CssClass="ft_gray444nu" Text='<%# Bind("sdefinition") %>'
                                    CausesValidation="False" OnClick="LinkindustryPress" CommandArgument='<%# Eval("subcatid") %>'></asp:LinkButton>
                                <asp:Label ID="Totalindustry" CssClass="ft_gray" runat="server" Text='<%# "["+Eval("ctotals")+"]" %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
            <div id="locdiv" class="scroll-pane">
                <div class="introundupdiv">
                    <asp:DataList ID="Locationlist" runat="server" RepeatColumns="2" RepeatLayout="Flow">
                        <ItemTemplate>
                            <div class="gr_tabdesc">
                                <img alt="bullet" src="/images/img_bull.gif" />
                                <asp:LinkButton ID="Linklocation" runat="server" CssClass="ft_gray444nu" Text='<%# Bind("sdefinition") %>'
                                    CausesValidation="false" OnClick="LinklocationPress" CommandArgument='<%# Eval("subcatid") %>'></asp:LinkButton>
                                <asp:Label ID="Totallocation" runat="server" CssClass="ft_gray" Text='<%# "["+ Eval("ctotals") +"]" %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
            <div id="saldiv" class="scroll-pane">
                <div class="introundupdiv">
                    <asp:DataList ID="Salarylist" runat="server" RepeatColumns="1" RepeatLayout="Flow">
                        <ItemTemplate>
                            <div class="gr_tabdesc">
                                <img alt="bullet" src="/images/img_bull.gif" />
                                <asp:LinkButton ID="Linksalary" runat="server" CssClass="ft_gray444nu" Text='<%# Bind("sdefinition") %>'
                                    CausesValidation="false" OnClick="LinksalaryPress" CommandArgument='<%# Eval("subcatid") %>'></asp:LinkButton>
                                <asp:Label ID="Totalsalary" runat="server" CssClass="ft_gray" Text='<%# "["+ Eval("ctotals") +"]" %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="tb_headtwo">
                <asp:Label ID="Label8" runat="server" Text="Label">Recruiter of week</asp:Label>
            </div>
            <div class="roundupdiv">
                <asp:GridView ID="recshufflegrid" runat="server" AutoGenerateColumns="False" BorderWidth="0px"
                    GridLines="None" PageSize="1" Width="100%" ShowHeader="false">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <div class="ln_fixx6">
                                </div>
                                <div class="dftrecdtsleft">
                                    <div class="im_wrap1">
                                        <div class="dv_shadow000">
                                            <asp:Image ID="recofweekimg" runat="server" CssClass="dftimgroundup wide75" ImageUrl='<%# Bind("Artifact_data") %>' />
                                        </div>
                                    </div>
                                </div>
                                <!-- replace w textbxs -->
                                <div class="dftrecdtsright">
                                    <asp:Label ID="recofweekname" runat="server" CssClass="ft_blackbd" Text='<%# Bind("Sponsored") %>'></asp:Label>
                                    <div class="ln_fixx4">
                                    </div>
                                    <asp:Label ID="recofweekdesc" runat="server" CssClass="ft_black" Text='<%# Bind("sDescription") %>'></asp:Label>
                                    <div class="ln_fixx2">
                                    </div>
                                    <a href="jobsbyrecruiter.aspx?empid=<%# Eval("empid") %>" class="ft_bluelink">more jobs
                                        from
                                        <%# Eval("Sponsored") %>
                                    </a>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div id="mainpgsright">
            <!-- fashion wall-->
            <div class="dv_fashionwall">
                <img style="visibility: hidden; width: 0px; height: 0px;" border="0" width="0" height="0" src="http://c.gigcount.com/wildfire/IMP/CXNID=2000002.11NXC/bT*xJmx*PTEzNTU2OTg4MjE1NjkmcHQ9MTM1NTY5ODg3MDgyMiZwPTkwMjA1MSZkPSZnPTEmb2Y9MA==.gif" /><object id="ci_55160_o" classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="656" height="300"><param name="movie" value="http://apps.cooliris.com/embed/cooliris.swf?t=1307582197" /><param name="allowFullScreen" value="true" /><param name="allowScriptAccess" value="always" /><param name="bgColor" value="#121212" /><param name="flashvars" value="z=FbNEOiyzMVK4" /><param name="wmode" value="opaque" /><embed id="ci_55160_e" type="application/x-shockwave-flash" src="http://apps.cooliris.com/embed/cooliris.swf?t=1307582197" width="656" height="300" allowfullscreen="true" allowscriptaccess="always" bgcolor="#121212" flashvars="z=FbNEOiyzMVK4" wmode="opaque"></embed></object>
            </div>
            <div class="dftstxleft">
                <div class="im_wrap1">
                    <div class="dv_shadow000">
                        <img src="/images/sprite.gif" alt="upload resume" class="img_main_box1" />
                    </div>
                </div>
            </div>
            <div class="dftstxleft">
                <asp:Label ID="dflab1" runat="server" CssClass="ft_black" Text="Upload your public resume and get head hunted by companies"></asp:Label>
                <div class="dv_fix">
                </div>
                <asp:HyperLink ID="HyperLink3" runat="server" CssClass="ft_bluelink" NavigateUrl="~/Jobseekers/Directapplication.aspx">Upload</asp:HyperLink>
            </div>
            <div class="dftstxleft">
                <div class="im_wrap1">
                    <div class="dv_shadow000">
                        <img src="/images/sprite.gif" alt="trending professions" class="img_main_box2" />
                    </div>
                </div>
            </div>
            <div class="dftstxleft">
                <asp:Label ID="dflab2" runat="server" CssClass="ft_black" Text="Explore the professions which are trending in fashion line"></asp:Label>
                <div class="dv_fix">
                </div>
                <asp:HyperLink ID="HyperLink4" runat="server" CssClass="ft_bluelink" NavigateUrl="~/jbtrends.aspx">View trends</asp:HyperLink>
            </div>
            <div class="dftstxleft">
                <div class="im_wrap1">
                    <div class="dv_shadow000">
                        <img src="/images/sprite.gif" alt="register with us" class="img_main_box3" />
                    </div>
                </div>
            </div>
            <div class="dftstxleft">
                <asp:Label ID="dflab3" runat="server" CssClass="ft_black" Text="Join us today! Keep track of applications and lot more"></asp:Label>
                <div class="dv_fix">
                </div>
                <asp:HyperLink ID="HyperLink5" runat="server" CssClass="ft_bluelink" NavigateUrl="~/Jobseekers/Signup.aspx">Register</asp:HyperLink>
            </div>
            <div class="dftstxleft">
                <div class="im_wrap1">
                    <div class="dv_shadow000">
                        <img src="/images/sprite.gif" alt="all recruiters" class="img_main_box4" />
                    </div>
                </div>
            </div>
            <div class="dftstxleft">
                <asp:Label ID="dflab4" runat="server" CssClass="ft_black" Text="Have a quick glance of who is recruiting"></asp:Label>
                <div class="dv_fix">
                </div>
                <asp:HyperLink ID="HyperLink6" runat="server" CssClass="ft_bluelink" NavigateUrl="~/Allrecruiters.aspx">Recruiters</asp:HyperLink>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx10">
            </div>
            <div class="ln_fixx8">
            </div>
        </div>
        <div class="dv_fix">
        </div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <div class="dvleft">
                <div class="tb_headtwo">
                    <asp:Label ID="Label11" runat="server" Text="Label">Articles</asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="scroll-pane">
                    <div class="introundupdiv">
                        <asp:DataList ID="Articlelist" runat="server" RepeatColumns="1" RepeatLayout="Flow">
                            <ItemTemplate>
                                <img alt="bullet" src="/images/img_bull.gif" />
                                <asp:LinkButton ID="Linksalary" runat="server" CssClass="ft_gray444nu" Text='<%# Bind("articlename") %>'
                                    CausesValidation="false" CommandArgument='<%# Eval("id_articles") %>' OnClick="LinksalaryClick"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
            </div>
            <div class="dvleft">
                <div class="dvleftinsider">
                    <div class="tb_headtwo">
                        Resume Services
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="roundupdiv">
                        <div class="ln_fixx6">
                        </div>
                        <div class="dftrecdtsleft">
                            <div class="im_wrap1">
                                <div class="dv_shadow000">
                                    <img src="/images/sprite.gif" alt="resume check" class="img_main_resserv" />
                                </div>
                            </div>
                        </div>
                        <div class="dftrecdtsright">
                            <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text="Get your resume re-written by one of our industry experts and improve your chances for finding the right job"></asp:Label>
                            <div class="dv_fix">
                            </div>
                            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_bluelink" NavigateUrl="/resumecenter/index.aspx">Resume Center</asp:HyperLink>
                        </div>
                    </div>
                    <br />
                </div>
            </div>
            <div class="dvleft">
                <div class="dvleftinsider">
                    <div class="tb_headtwo">
                        Salary Benchmark
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="roundupdiv">
                        <div class="ln_fixx6">
                        </div>
                        <div class="dftrecdtsleft">
                            <div class="im_wrap1">
                                <div class="dv_shadow000">
                                    <img src="/images/sprite.gif" alt="salary graph" class="img_main_benchmark" />
                                </div>
                            </div>
                        </div>
                        <div class="dftrecdtsright">
                            <asp:Label ID="Label6" runat="server" CssClass="ft_black" Text="See the Salary graph and how much are the average wages of people in your profession"></asp:Label>
                            <div class="dv_fix">
                            </div>
                            <asp:HyperLink ID="HyperLink2" runat="server" CssClass="ft_bluelink" NavigateUrl="~/salarycalc/salaryresult.aspx">Salary benchmarks</asp:HyperLink>
                        </div>
                    </div>
                </div>
            </div>
            <div class="dvleft">
                <div class="dv_customaddthis">
                    <a href="http://www.facebook.com/pages/fashionquadrant" target="_blank">
                        <img src="/images/sprite.gif" alt="facebook" class="img_home_fb" /></a>
                    <div class="ln_fixx10">
                    </div>
                    <a href="http://www.youtube.com/fashionquadrant" target="_blank">
                        <img src="/images/sprite.gif" alt="youtube" class="img_home_youtube" /></a>
                    <div class="ln_fixx10">
                    </div>
                    <a href="http://www.twitter.com/fashionquadrant" target="_blank">
                        <img src="/images/sprite.gif" alt="twitter" class="img_home_twitter" /></a>
                </div>
            </div>
            <div class="dv_fix">
            </div>
        </asp:PlaceHolder>
        <div class="dv_fix">
        </div>
    </div>

</asp:Content>
