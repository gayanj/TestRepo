<%@ Page Title="" Language="C#" MasterPageFile="~/JOB.Master" AutoEventWireup="true"
    CodeBehind="JobDetails.aspx.cs" Inherits="JB.Jobdetails" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- top bar -->
    <div class="divsimpletop">
     
        <asp:Label ID="Label11" runat="server" CssClass="ft_whitebd" Text="job description"></asp:Label>
         
    </div>
    <div class="boxcorner">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
        </asp:ScriptManager>
         
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="dv_fix">
                </div>
                <div class="jobdetailtpmarker">
                    <div id="jobdetaillt">
                     
                        
                        <div class="jobdetailcardv">
                            <div class="ln_fixx6">
                            </div>
                            <div class="im_wrap1">
                                <div class="dv_shadow000">
                                    <asp:Image ID="Image7" runat="server" Height="75px" Width="75px" />
                                </div>
                            </div>
                            <!-- categories -->
                            <div>
                                <br />
                                <div class="styledbordertp">
                                    <asp:Label ID="Label33" runat="server" CssClass="ft_blackbd" Text="Job Title"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label32" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label25" runat="server" CssClass="ft_blackbd" Text="Ref #"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label26" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label13" runat="server" CssClass="ft_blackbd" Text="Salary"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label20" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label14" runat="server" CssClass="ft_blackbd" Text="Company"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label21" runat="server" CssClass="ft_black"></asp:Label></div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label16" runat="server" CssClass="ft_blackbd" Text="Date Posted"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label23" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label15" runat="server" CssClass="ft_blackbd" Text="Contract Type"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label22" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label12" runat="server" CssClass="ft_blackbd" Text="Location"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label19" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label1" runat="server" CssClass="ft_blackbd" Text="Categories"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="LabelIndustries" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label28" runat="server" CssClass="ft_blackbd" Text="Hours"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label30" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label2" runat="server" CssClass="ft_blackbd" Text="Experience"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label3" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label5" runat="server" CssClass="ft_blackbd" Text="Sectors"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Labelsectors" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label7" runat="server" CssClass="ft_blackbd" Text="Career Level"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Labelcareer" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label9" runat="server" CssClass="ft_blackbd" Text="Education"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Labeleducation" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <div>
                                <div class="styledbordertp">
                                    <asp:Label ID="Label29" runat="server" CssClass="ft_blackbd" Text="Website"></asp:Label>
                                </div>
                                <div class="styledborder">
                                    <asp:Label ID="Label31" runat="server" CssClass="ft_black"></asp:Label>
                                </div>
                            </div>
                            <div class="dv_fix">
                            </div>
                        </div>
                         
                        
                        <!-- vcardend-->
                        <div class="dv_fix">
                        </div>
                        <div class="jobdetailsprevpg">
                            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="JdprevjobClick" ImageUrl="/images/img_prevbtn.gif" />
                        </div>
                        <div class="jobdetailsnextpg">
                            <asp:ImageButton ID="ImageButton2" runat="server" OnClick="JdnextjobClick" ImageUrl="/images/img_nextbtn.gif" />
                        </div>
                        <div class="dv_fix">
                        </div>
                        <!--testend-->
                        <div class="ln_fixx10">
                        </div>
                        <div class="ln_fixx10">
                        </div>
                        <!-- description -->
                        <div class="jobdetailspaddet">
                         
                            <asp:Label ID="Label17" runat="server" Text="Role Details" CssClass="smap_lefts"></asp:Label>
                             
                            <div class="dv_fix">
                            </div>
                            <div class="tb_headone">
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_444">
                            </div>
                            <br />
                            <div>
                                <asp:Label ID="Label18" runat="server" CssClass="ft_black"></asp:Label>
                            </div>
                        </div>
                        <div class="dv_fixmore">
                        </div>
                        <div class="jobdetailspaddet">
                            <div class="styledbordertp">
                             
                                <asp:Label ID="Label24" runat="server" CssClass="ft_blackbd" Text="Contact Person"></asp:Label>
                                 
                            </div>
                            <div class="styledborder">
                                <asp:Label ID="Label27" runat="server" CssClass="ft_black"></asp:Label>
                            </div>
                        </div>
                        <div class="dv_fix">
                        </div>
                    </div>
                    <div id="reportpg">
                     
                        <div class="jobdetailbr">
                            <div class="smap_lefts">
                                <asp:Label ID="Label4" runat="server" Text="Your Options"></asp:Label>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="tb_headone">
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_444">
                            </div>
                            <div class="ln_fixx2">
                            </div>
                            <img src="/images/dt_block.gif" alt="report" />
                            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Button1Click" CssClass="ft_bluelink">Report this page</asp:LinkButton>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx2">
                            </div>
                            <img src="/images/lt_maill.gif" alt="report" />
                            <asp:LinkButton ID="LinkButton1" CssClass="ft_bluelink" runat="server" OnClick="LinkButton1Click">Email this page</asp:LinkButton>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx2">
                            </div>
                            <asp:Label ID="Labelsharethis" runat="server" CssClass="ft_bluelinkwnodeco" Text=""></asp:Label>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx2">
                            </div>
                            <div class="dv_fix">
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <div class="jobdetailbr">
                            <div class="ln_fixx10">
                            </div>
                            <div class="dv_fix">
                            </div>
                            <asp:Panel ID="Marketbasketdetail" runat="server" Visible="true">
                                <div class="smap_lefts">
                                    <asp:Label ID="Marketbaskethead" runat="server" Text="You may be interested in"></asp:Label>
                                </div>
                                <div class="tb_headonefrjbdet">
                                </div>
                                <div class="dv_fix">
                                </div>
                                <div class="ln_444">
                                </div>
                                <div class="ln_fixx2">
                                </div>
                            </asp:Panel>
                        </div>
                        <div class="dv_fix">
                        </div>
                         
                    </div>
                    <div class="dv_fix">
                    </div>
                    <br />
                    <div class="jobdetailleft40">
                     
                        <asp:Button ID="Button2" runat="server" CssClass="button" Text="  Apply  " OnClick="Button2Click" />
                        &nbsp;<asp:Button ID="JBAddtocart" runat="server" CssClass="button" Text="  Save  "
                            OnClientClick="return procdetailaddcart();" Visible="False" />
                             
                    </div>
                    <br />
                    <div class="dv_fix">
                    </div>
                    <br />
                </div>
                <div class="dv_fix">
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
         
    </div>
</asp:Content>