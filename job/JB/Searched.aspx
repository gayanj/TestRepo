<%@ Page Title="" Language="C#" MasterPageFile="~/JOB.Master" AutoEventWireup="true"
    CodeBehind="Searched.aspx.cs" Inherits="JB.Searched" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <link href="/styles/pheonixv6.css" rel="stylesheet" type="text/css" />
    <link type="text/css" href="/styles/jquery.jscrollpane.css" rel="stylesheet" />
    <script src="/scripts/scrollv11.js" type="text/javascript"></script>
    <script src="/scripts/scrollv12.js" type="text/javascript"></script>
    <link type="text/css" href="/styles/dragon.css" rel="stylesheet" />
    <script src="/scripts/dragon1.js" type="text/javascript"></script>
    <script src="/Scripts/jquery-ui.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server">
    </asp:ScriptManager>
    <div class="dv_fix">
    </div>
    <br />
    <div id="searchedl1">
        <!-- search control-->
        <!--<div class="dv_clearfilter">
                    </div>-->
        <div class="dv_shadow000">
            <div class="divback">
                <div class="dvleft">
                    <asp:Label ID="Label1" runat="server" CssClass="ft_whitebd" Text="search"></asp:Label>
                </div>
                <!--
                            <div class="searchedprog">
                                <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="JavascriptPanel1"
                                    DisplayAfter="1">
                                    <ProgressTemplate>
                                        <asp:Image ID="Image11" runat="server" ImageUrl="/images/img_boxloader.gif" />
                                    </ProgressTemplate>
                                </asp:UpdateProgress>
                            </div>
                            -->
            </div>
            <div id="srchbox" class="divsimplebox">
                <div id="dvclear">
                </div>
                <div class="ln_fixx4">
                </div>
                <div class="lftp2">
                </div>
                <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="None" CssClass="searchtextboxline"
                    MaxLength="255"></asp:TextBox>
                <div class="dvclear">
                </div>
                <asp:CheckBox ID="CheckBoxInternet" runat="server" CssClass="ft_black" Text="Target my current location" />
                <div class="dvclear">
                </div>
                <asp:CheckBox ID="CheckBoxVideo" runat="server" CssClass="ft_black" Text="Jobs with videos only" />
                <div class="dvclear">
                </div>
                <!-- dyna selections -->
                <div id="srdynaselect">
                    <asp:Panel ID="Panelsrdynas" runat="server">
                    </asp:Panel>
                </div>
                <!-- end dyna selection -->
                <div class="dv_fix">
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for radius search-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="radm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltradius');showdivs('radp');hidedivs('radm');" />
                    <img id="radp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltradius');showdivs('radm');hidedivs('radp');" />
                    <asp:Label ID="Label23" runat="server" CssClass="ft_blackbd" Text="Radius"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltradius">
                    <asp:Label ID="Label11" runat="server" CssClass="ft_black" Text="Within"></asp:Label>
                    <asp:DropDownList ID="DropDownListmiles" CssClass="dropdwn1" runat="server">
                        <asp:ListItem Selected="True" Value="0">ALL</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>40</asp:ListItem>
                        <asp:ListItem>50</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label21" runat="server" CssClass="ft_black" Text=" miles of "></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt" Width="66px"></asp:TextBox>

                </div>
                <div class="ln_fixx10">
                </div>
                <div class="dv_fix">
                </div>
                <!--company search -->
                <div class="tb_jobctrlh1">
                    <img id="comm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltcompany');showdivs('comp');hidedivs('comm');" />
                    <img id="comp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltcompany');showdivs('comm');hidedivs('comp');" />
                    <asp:Label ID="Label29" runat="server" CssClass="ft_blackbd" Text="Company"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltcompany">
                    <asp:TextBox ID="TextBoxCompany" CssClass="searchtextboxline" runat="server"></asp:TextBox>

                </div>
                <div class="ln_fixx10">
                </div>
                <!--date search -->
                <div class="tb_jobctrlh1">
                    <img id="datem" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltdate');showdivs('datep');hidedivs('datem');" />
                    <img id="datep" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltdate');showdivs('datem');hidedivs('datep');" />
                    <asp:Label ID="Label30" runat="server" CssClass="ft_blackbd" Text="Posted Date"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltdate">
                    <asp:DropDownList ID="DropDowndate" runat="server" CssClass="dropdwndayrange">
                        <asp:ListItem Value="12000">All</asp:ListItem>
                        <asp:ListItem Value="12001">Today</asp:ListItem>
                        <asp:ListItem Value="12002">Yesterday</asp:ListItem>
                        <asp:ListItem Value="12003">Last 3 Days</asp:ListItem>
                        <asp:ListItem Value="12004">Last 7 Days</asp:ListItem>
                        <asp:ListItem Value="12005">Last 30 Days</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for category-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="indm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltindustry');showdivs('indp');hidedivs('indm');" />
                    <img id="indp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltindustry');showdivs('indm');hidedivs('indp');" />
                    <asp:Label ID="Label14" runat="server" CssClass="ft_blackbd" Text="Categories"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltindustry" class="scroll-pane">
                    <asp:Panel ID="CheckBoxList1" runat="server">
                    </asp:Panel>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for sectors-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="secm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltsector');showdivs('secp');hidedivs('secm');" />
                    <img id="secp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltsector');showdivs('secm');hidedivs('secp');" />
                    <asp:Label ID="Label7" runat="server" CssClass="ft_blackbd" Text="Sectors"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltsector" class="scroll-pane">
                    <asp:Panel ID="CheckBoxList7" runat="server">
                    </asp:Panel>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for location-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="locm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltlocation');showdivs('locp');hidedivs('locm');" />
                    <img id="locp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltlocation');showdivs('locm');hidedivs('locp');" />
                    <asp:Label ID="Label15" runat="server" CssClass="ft_blackbd" Text="Location"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltlocation" class="scroll-pane">
                    <asp:Panel ID="CheckBoxList2" runat="server">
                    </asp:Panel>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for salary range-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="salm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltsalary');showdivs('salp');hidedivs('salm');" />
                    <img id="salp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltsalary');showdivs('salm');hidedivs('salp');" />
                    <asp:Label ID="Label18" runat="server" CssClass="ft_blackbd" Text="Salary"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltsalary" class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList6" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <div class="dv_fix"></div>
                <div class="ln_fixx4">
                </div>
                <div class="ln_dotted">
                </div>
                <div class="ln_fixx4">
                </div>
                <div class="dv_fix"></div>
                <div class="dvleftinsider">
                    <asp:Label ID="Label38" runat="server" Text="In Currency" CssClass="ft_black"></asp:Label>
                    <asp:DropDownList ID="Currency" runat="server" CssClass="dropdwn1">
                        <asp:ListItem Value="16002" Selected="True">£ | GBP</asp:ListItem>
                        <asp:ListItem Value="16001">$ | USD</asp:ListItem>
                        <asp:ListItem Value="16003">€ | EUR</asp:ListItem>
                        <asp:ListItem Value="16004">CHF</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <!-- div for experience-->
                <div class="dv_fix">
                </div>
                <div class="ln_fixx4">
                </div>
                <div class="ln_dotted">
                </div>
                <div class="ln_fixx4">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="emplm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltemployer');showdivs('emplp');hidedivs('emplm');" />
                    <img id="emplp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltemployer');showdivs('emplm');hidedivs('emplp');" />
                    <asp:Label ID="Label6" runat="server" CssClass="ft_blackbd" Text="Experience"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltemployer" class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList5" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for careerlevel-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="carm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltcareer');showdivs('carp');hidedivs('carm');" />
                    <img id="carp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltcareer');showdivs('carm');hidedivs('carp');" />
                    <asp:Label ID="Label32" runat="server" CssClass="ft_blackbd" Text="Career Level"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltcareer" class="scroll-pane">
                    <asp:CheckBoxList ID="CheckBoxList9" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for contract-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="contm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvltcontract');showdivs('contp');hidedivs('contm');" />
                    <img id="contp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvltcontract');showdivs('contm');hidedivs('contp');" />
                    <asp:Label ID="Label16" runat="server" CssClass="ft_blackbd" Text="Contract"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvltcontract" class="searchedstmod">
                    <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for education-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="edum" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvlteducation');showdivs('edup');hidedivs('edum');" />
                    <img id="edup" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvlteducation');showdivs('edum');hidedivs('edup');" />
                    <asp:Label ID="Label31" runat="server" CssClass="ft_blackbd" Text="Education"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvlteducation" class="searchedstmod">
                    <asp:CheckBoxList ID="CheckBoxList8" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <div class="ln_fixx10">
                </div>
                <!-- div for hours-->
                <div class="dv_fix">
                </div>
                <div class="tb_jobctrlh1">
                    <img id="hrsm" src="/images/dv_minus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="hidedivs('dvlthours');showdivs('hrsp');hidedivs('hrsm');" />
                    <img id="hrsp" src="/images/dv_plus.gif" alt="close" onmouseover="this.className='hinternal'"
                        onclick="showdivs('dvlthours');showdivs('hrsm');hidedivs('hrsp');" />
                    <asp:Label ID="Label5" runat="server" CssClass="ft_blackbd" Text="Hours"></asp:Label>
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="ln_fixx2">
                </div>
                <div id="dvlthours" class="searchedstmod">
                    <asp:CheckBoxList ID="CheckBoxList4" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                    </asp:CheckBoxList>
                </div>
                <div class="ln_fixx10">
                </div>
                <!--search button-->
                <div class="dvclear">
                </div>
                <div class="ln_fixx4">
                </div>
                <asp:Button ID="Button1" runat="server" CausesValidation="False" CssClass="button"
                    OnClick="Button1Click" Text="Search" />
                &nbsp;<asp:Button ID="ButtonSaveSrch" runat="server" CausesValidation="False" Visible="false"
                    CssClass="button" Text="Save Search" OnClientClick="changecss(); return false;" />
            </div>
        </div>
        <!-- end search control-->
        <br />
        <asp:UpdatePanel ID="UpdatePanelSaveSearch" runat="server">
            <ContentTemplate>
                <!-- this is for the saved search-->
                <div id="dv_savedsearch" class="centered">
                    <div class="dv_shadowpop1">
                        <div class="dv_popinner">
                            <asp:Panel ID="Panel1" runat="server">
                                <div class="dv_popupheader">
                                    <div class="dvleft">
                                        <asp:Label ID="Label37" runat="server" Text="Saving Search..." CssClass="ft_whitebd"></asp:Label>
                                    </div>
                                    <div class="dvright">
                                        <img alt="close" src="/images/dv_closelabelwhite.gif" onclick="changecssoff(); return false;"
                                            onmouseover="this.className='mova1'" onmouseout="this.className='mout1'" />
                                    </div>
                                </div>
                                <div class="dv_fix">
                                </div>
                                <div class="dv_popupbody">
                                    <img alt="one" src="/images/nm_one.gif" />&nbsp;
                                        <asp:Label ID="Label36" runat="server" CssClass="ft_black" Text="Name this Search"></asp:Label>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="ft_red"
                                        ErrorMessage="Required" ControlToValidate="TextBoxSavedSearchName"></asp:RequiredFieldValidator>
                                    <br />
                                    <asp:TextBox ID="TextBoxSavedSearchName" runat="server" CssClass="TextboxSt"></asp:TextBox>
                                    <div class="ln_fixx6">
                                    </div>
                                    <asp:Button ID="ButtonSaveSearch" runat="server" Text="Save" CssClass="button" OnClick="ButtonSaveSearchClick"
                                        CausesValidation="false" />
                                </div>
                            </asp:Panel>
                        </div>
                    </div>
                </div>
                <!-- end saved search -->
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="searchedl2">
        &nbsp;
    </div>
    <div class="searchedl3">
        <!--grid-->
        <div class="boxmid">
            <div class="dv_fix">
            </div>
            <div id="dvbk" class="divback">
                <div class="dvleft">
                    <asp:Label ID="Label13" runat="server" CssClass="ft_white" Text="Jobs"></asp:Label>
                </div>
                <div class="browser">
                    <div class="dv_fix">
                    </div>
                    <div id="optoptoggle" onmouseover="this.className='srcheffectshim'" onmouseout="this.className='optoptoggle'"
                        onclick="showhideoptions();">
                        <div class="srchedoptpans">
                            <asp:Image ID="settingimage" runat="server" ImageUrl="/images/tp_settings.png" onmouseover="this.className='hinternal'" />
                        </div>
                        <div class="srchedoptpans">
                            Options
                        </div>
                    </div>
                    <div id="brshowtop" onmouseover="this.className='srcheffectshim'" onmouseout="this.className='brshowtop'"
                        onclick="showdivs('brhidetop');hidedivs('brshowtop');$('#browsedetails').slideDown();createCookie('fq_browse',1,10);">
                        <div class="srchedoptpansimg">
                            <asp:Image ID="pimge" runat="server" ImageUrl="/images/dv_plus.gif" onmouseover="this.className='hinternal'" />
                        </div>
                        <div class="srchedoptpans">
                            Browse
                        </div>
                    </div>
                    <div id="brhidetop" onmouseover="this.className='srcheffectshim'" onmouseout="this.className='brhidetop'"
                        onclick="showdivs('brshowtop');hidedivs('brhidetop');$('#browsedetails').slideUp();createCookie('fq_browse',0,10);">
                        <div class="srchedoptpansimg">
                            <asp:Image ID="pimgc" runat="server" ImageUrl="/images/dv_minus.gif" onmouseover="this.className='hinternal'" />
                        </div>
                        <div class="srchedoptpans">
                            Browse
                        </div>
                    </div>
                    <div class="dv_fix">
                    </div>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div id="browsedetails" class="divsimpleboxlight">
                <div class="dv_fix">
                </div>
                <div class="dftoptionsleft10x">
                    <asp:Label ID="Label35" runat="server" Text="You are viewing jobs under: " CssClass="ft_white"></asp:Label>
                    <div class="ln_fixx6">
                    </div>
                    <div class="ln_dotted">
                    </div>
                    <div class="ln_fixx6">
                    </div>
                    <asp:DataList ID="BrowsingList" runat="server" RepeatColumns="3" BorderStyle="None"
                        ShowFooter="False" ShowHeader="False" RepeatLayout="Flow">
                        <ItemTemplate>
                            <div class="ux_browsebox">
                                <asp:LinkButton ID="LinkButton5" runat="server" CssClass="ft_gainbronze" Text='<%# Bind("sdefinition") %>'
                                    CommandArgument='<%# CreateUrl(Eval("viewcatid"),Eval("subcatid")) %>' CausesValidation="false" OnClick="LinkButton5Click"></asp:LinkButton>
                                <asp:Label ID="ltext1" runat="server" CssClass="ft_gray" Text='<%# Bind("ctotals") %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                    <div class="ln_fixx6">
                    </div>
                    <div class="ln_dotted">
                    </div>
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div id="optionspanels" class="divsimpleboxlight">
                <div class="dftoptionsleft10x">
                    <div class="ft_white">
                        Show job details in Search:
                    </div>
                    <a href="#" class="ft_gainbronze" onclick="showgriddesc();">Yes</a>
                    <asp:Label ID="Label24" runat="server" CssClass="ft_gainbronze" Text="|"></asp:Label>
                    <a href="#" class="ft_gainbronze" onclick="hidegriddesc();">No</a>
                    <div class="ln_fixx6">
                    </div>
                    <div class="ln_dotted">
                    </div>
                </div>
                <div class="dftoptionsleft10x">
                    <div class="ln_fixx8">
                    </div>
                    <div class="ft_white">
                        Jobs per page:
                    </div>
                    <div class="ln_fixx1">
                    </div>
                    <label for="jobsperpage10" onclick="createCookie('fq_pagesize', 10, 10); gotohome();" class="ft_gainbronze">10</label>
                    <label class="ft_gainbronze">| </label>
                    <label for="jobsperpage20" onclick="createCookie('fq_pagesize', 20, 10); gotohome();" class="ft_gainbronze">20</label>
                    <label class="ft_gainbronze">| </label>
                    <label for="jobsperpage30" onclick="createCookie('fq_pagesize', 50, 10); gotohome();" class="ft_gainbronze">50</label>


                    <div class="ln_fixx4">
                    </div>
                </div>
            </div>
            <div class="dv_fix">
            </div>

            <div id="upgrid1" class="centgrid">
                <!-- sponsored jobs-->
                <div id="sponsrjbcover">
                    <div class="srgridleftitem">
                        <div class="ln_fixx6">
                        </div>
                        <asp:HyperLink ID="sponsrhlink1" CssClass="ft_graybd" runat="server"></asp:HyperLink>
                        <div class="ln_fixx6">
                        </div>
                        <asp:Label ID="sponsrdesc" CssClass="ft_black" runat="server" Text=""></asp:Label>
                        <div class="ln_fixx6">
                        </div>
                        <asp:HyperLink ID="sponsrhlink2" CssClass="ft_blacklink" runat="server">Apply Now</asp:HyperLink>
                    </div>
                    <div class="srgridrightitem">
                        <div class="ln_fixx6">
                        </div>
                        <div class="ft_gray">
                            Ads
                        </div>
                    </div>
                </div>

                <!-- no result -->
                <asp:Label ID="LabelNoResult" runat="server" Visible="false" Text="No Results! Please refine your search." CssClass="ft_backhighh1"></asp:Label>

                <!-- jobs -->
                <br />
                <asp:GridView ID="JobsList" runat="server" AutoGenerateColumns="False"
                    GridLines="None"
                    OnRowDataBound="JobsListRowDataBound" ShowHeader="False" Width="100%" AllowPaging="false">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <div class="ln_fixx4">
                                </div>
                                <div>
                                    <div class="srgridleftitem">
                                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# GetUrl(Eval("idjobs"),Eval("stitle")) %>'
                                            CssClass="ft_blueh1" Text='<%# Bind("sTitle") %>'></asp:HyperLink>
                                        <asp:Image ID="Hyperimg" runat="server" ImageUrl="/images/mp_video.gif" Visible='<%# Convert.ToBoolean( Eval("video") ) %>'></asp:Image>
                                        <div class="ln_fixx4">
                                        </div>
                                        <asp:Label ID="Labeldadvert" runat="server" CssClass="ft_gray" Text="Posted on "></asp:Label>
                                        <asp:Label ID="Labeldadvertout" runat="server" CssClass="ft_gray" Text='<%# Bind("dtEnteredDate","{0:dd/M/yyyy}") %>'></asp:Label>
                                        <asp:Label ID="Label12" runat="server" CssClass="ft_gray" Text=", with "></asp:Label>
                                        <asp:Label ID="Label4" runat="server" CssClass="ft_gray" Text='<%# Bind("sSalaryText") %>'></asp:Label>
                                        <asp:Label ID="Label28" runat="server" CssClass="ft_gray" Text=" based in "></asp:Label>
                                        <asp:Label ID="Label27" runat="server" CssClass="ft_gray" Text='<%# Bind("sLocation") %>'></asp:Label>
                                        <asp:Label ID="Label33" runat="server" CssClass="ft_gray" Text="and advertized by "></asp:Label>
                                        <asp:Label ID="Label34" runat="server" CssClass="ft_gray" Text='<%# Bind("Company") %>'></asp:Label>
                                        <p>
                                            <asp:Label ID="Label2" runat="server" CssClass="ft_gray444" Text='<%# Bind("sShortDescription") %>'></asp:Label>
                                        </p>
                                    </div>
                                    <div class="srgridrightitem">
                                        <asp:HyperLink ID="HyperLink4" runat="server" CssClass="ft_blacklink" NavigateUrl='<%# GetUrl(Eval("idjobs"),Eval("stitle")) %>'
                                            Text="Apply"></asp:HyperLink>
                                        <div class="ln_fixx1">
                                        </div>
                                        <asp:LinkButton ID="LinkButton1" CssClass="ft_blacklink" CausesValidation="false"
                                            runat="server" Visible="false">Save</asp:LinkButton>
                                    </div>
                                </div>
                                <div class="dv_fix">
                                </div>
                                <div class="ln_fixx4">
                                </div>
                                <div class="ln_ccc">
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <div class="ux_cpaged">
                    <asp:Literal ID="CustomPaging" runat="server"></asp:Literal>
                </div>
                <br />
                <br />
            </div>
        </div>
    </div>
    <div class="searchedl2">
        &nbsp;
    </div>

    <div class="searchedl3">
        <div class="dv_shadow000">
            <div class="divback">
                <asp:Label ID="Label20" runat="server" CssClass="ft_whitebd" Text="sponsored"></asp:Label>
            </div>
            <div>
                <div class="divsimplebox">
                    <asp:DataList ID="SponsoredLists" Width="100%" runat="server">
                        <ItemTemplate>
                            <div class="featrecgitem">
                                <div class="ln_fixx10">
                                </div>
                                <asp:Image ID="Image7" runat="server" Height="75px" Width="75px" ImageUrl='<%# Bind("artifact_data") %>' />
                                <div class="ln_fixx4">
                                </div>
                                <asp:Label ID="Label3" runat="server" CssClass="ft_gray" Text="is looking for "></asp:Label>
                                <div class="ln_fixx4">
                                </div>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_graybd" NavigateUrl='<%# String.Format("/jobdetails?jobid={0}&jobtitle={1}", Eval("idjobs"), Eval("sTitle")).Replace(" ", "-").Replace("--", "-").Replace("--", "-") %>'
                                    Text='<%# Eval("sTitle").ToString().Substring(0,Math.Min(18,Eval("sTitle").ToString().Length))+ "..." %>'></asp:HyperLink>
                                <div class="ln_fixx10">
                                </div>
                            </div>
                            <div class="ln_fixx4">
                            </div>
                        </ItemTemplate>
                    </asp:DataList>
                </div>
            </div>
        </div>
        <div class="ln_fixx10">
        </div>

        <asp:UpdatePanel ID="JavascriptPanel1" runat="server">
            <ContentTemplate>
                <!--feedback form start-->
                <div id="suggestion" class="dv_shadow000">
                    <div id="suggests" onmouseover="showdivs('dftimprovert');" onmouseout="hidedivs('dftimprovert');">
                        <div class="divback">
                            <div id="dftimprovelft">
                                <asp:Label ID="Label19" runat="server" CssClass="ft_whitebd" Text="suggestions"></asp:Label>
                            </div>
                            <div id="dftimprovert" onclick="hidedivs('suggests');createCookie('fq_suggest',1,1);">
                                <img alt="close" onmouseover="this.className='hinternal'" src="/images/mp_labelclosewt.gif" />
                            </div>
                        </div>
                        <div class="divsimplebox">
                            <asp:Panel ID="suggestmainpan" runat="server">
                                <div class="ft_notify">
                                    <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="suggalignleft">
                                    <asp:Label ID="Label8" runat="server" CssClass="ft_blackbd" Text="Your Email"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxSt" Width="99%"></asp:TextBox>
                                    <asp:TextBoxWatermarkExtender ID="TextBox3_TWE" runat="server" Enabled="True" TargetControlID="TextBox3"
                                        WatermarkCssClass="TextboxSttwe" WatermarkText="e.g. ann@eg.com">
                                    </asp:TextBoxWatermarkExtender>
                                </div>
                                <div class="suggalignleft">
                                    <asp:Label ID="Label9" runat="server" CssClass="ft_blackbd" Text="Suggestion"></asp:Label>

                                </div>
                                <div class="suggalignleft">
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="TextboxSt" Height="50px" TextMode="MultiLine"
                                        Width="98%"></asp:TextBox>
                                </div>
                                <div class="suggalignleft">
                                    <div class="setpxline">
                                    </div>
                                    <asp:Button ID="Button2" runat="server" CssClass="button" OnClick="Button2Click"
                                        Text="Send" CausesValidation="false" />
                                </div>
                            </asp:Panel>
                            <asp:Panel ID="Panelsuggresult" runat="server" Visible="false">
                                <asp:Label ID="Label10" runat="server" Text="Thank you for your suggestion! we cannot provide feedback individually but we do notice each and every suggestion."
                                    CssClass="ft_gray444" Visible="False" Width="140px"></asp:Label>
                            </asp:Panel>
                        </div>
                    </div>
                </div>
                <div class="ln_fixx10">
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <!--feedback form ends here-->
        <!-- google adwords start here -->
        <div id="googadss">
        </div>
        <!-- google ad words end here -->
        <div class="dv_fix">
        </div>
        <div class="ln_fixx4">
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_fixx4">
        </div>
    </div>



</asp:Content>
