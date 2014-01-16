<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbAbout.aspx.cs" Inherits="JB.Jbabout" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
    
        <div class="ft_whitebd">
            About Us</div>
            
    </div>
    <div class="boxcorner">
        <br />
        <asp:Panel ID="Jbabouts1" runat="server">
            <div class="dv_docgenrics">
                <div class="smap_lefts">
                    About Us</div>
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
                <div class="ft_blackjust">
                    <br />
                    Updated: 4.3.2012
                    <br />
                    <br />
                    <br />
                    We started this site with one aim only, i.e with a motivation to help the recruiters
                    find the correct talent. We are an online employement solution for industries and
                    sectors who want to increase their ROI by switching over to our global network.
                    We connect employers with jobseekers at all levels and across wider domains so that
                    the true potential of HR sector could be extracted.
                    <br />
                    <br />
                    <b>Fashion Quadrant</b>
                    <br />
                    <br />
                </div>
            </div>
        </asp:Panel>
    </div>
</asp:Content>