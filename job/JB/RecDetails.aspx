<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecDetails.aspx.cs" MasterPageFile="~/Job.Master"
    Inherits="JB.Recdetails" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv1.css" rel="stylesheet" type="text/css" />
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
    <link href="/styles/jobmaster.css" rel="stylesheet" type="text/css" />
    <!--begin scroll-->
    <link href="/styles/pheonixv7.css" rel="stylesheet" type="text/css" />
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <link type="text/css" href="/styles/jqueryvx.js.jscrollpane.css" rel="stylesheet" media="all" />
    <script type="text/javascript" src="/Scripts/jqueryvx.js.mousewheel.js"></script>
    <script type="text/javascript" src="/Scripts/jqueryvx.js.jscrollpane.min.js"></script>
    <!--hook up the scrollers -->
    <script type="text/javascript">
        $(function () { var a = $(window), b = false; a.bind("resize", function () { if (!b) { b = true; var c = $("#full-page-container"); c.css({ width: 1, height: 1 }); c.css({ width: a.width(), height: a.height() }); b = false; c.jScrollPane({ showArrows: false }) } }).trigger("resize"); $("body").css("overflow", "hidden"); $("#full-page-container").width() != a.width() && a.trigger("resize"); $(".scroll-pane").jScrollPane({ showArrows: false }) })
    </script>
    <!-- end scroll -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="boxcorner">
        <div class="dv_docgenrics">
            <br />
            <div class="smap_lefts">
                 
                <asp:Label ID="Label2" runat="server" Text="Digital Card"></asp:Label>
            </div>
             
            <div class="dv_fix">
            </div>
            <div class="tb_headone">
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="im_wrap1">
                <div class="dv_shadow000">
                    <asp:Image ID="RecImage" runat="server" Height="75px" Width="75px" />
                </div>
            </div>
            <br />
            <br />
            <div class="ft_blackbd">
                 
                Company Name
                 
            </div>
            <div class="ln_fixx2">
            </div>
            <asp:Label ID="CompanyName" runat="server" CssClass="ft_black"></asp:Label>
            <br />
            <br />
            <div class="ft_blackbd">
                 
                Company Introduction
                 
            </div>
            <div class="ln_fixx2">
            </div>
            <asp:Label ID="CompanyIntro" runat="server" CssClass="ft_black"></asp:Label>
            <br />
            <br />
            <div class="ft_blackbd">
                 
                Business Detail
                 
            </div>
            <div class="ln_fixx2">
            </div>
            <asp:Label ID="CompanyBusinessDetail" runat="server" CssClass="ft_black"></asp:Label>
            <br />
            <br />
            <div class="ft_blackbd">
                 
                Company Website
                 
            </div>
            <div class="ln_fixx2">
            </div>
            <asp:Label ID="CompanyWebsite" runat="server" CssClass="ft_black"></asp:Label>
            <br />
            <br />
            <div class="ft_blackbd">
                 
                Contact Person Email
                 
            </div>
            <div class="ln_fixx2">
            </div>
            <asp:Label ID="CompanyEmail" runat="server" CssClass="ft_black"></asp:Label>
            <div class="dv_fix">
            </div>
        </div>
    </div>
    <div class="dv_fix">
    </div>
</asp:Content>
