<%@ Page Title="" Language="C#" MasterPageFile="~/JOB.Master" AutoEventWireup="true"
    CodeBehind="Applications.aspx.cs" Inherits="JB.Applications" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixc1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <!-- TOP NAV-->
    <div class="divsimpletop">
    
        <asp:Label ID="Label13" runat="server" CssClass="ft_whitebd" Text="Application in progress"></asp:Label>
        
    </div>
    <!-- div for details page -->
    <div class="boxcorner">
    
        <br />
        <div id="applicationsbreak">
            <div>
                <img alt="one" src="/images/nm_one.gif" />&nbsp;<asp:Label ID="Label11" runat="server"
                    CssClass="ft_black" Text="Register to receive jobs by email!" Width="200px"></asp:Label>
                <asp:Button ID="Button2" runat="server" CssClass="button" Text="Register   " OnClick="Button2Click" />
            </div>
            <div class="dv_fix">
            </div>
            <div>
                <div class="ln_fixx10">
                </div>
                <div id="applicationsleft">
                </div>
                <div id="applicationsmiddle">
                    OR
                </div>
                <div id="applicationsright">
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx10">
            </div>
            <div>
                <img alt="two" src="/images/nm_two.gif" />&nbsp;<asp:Label ID="Label12" runat="server"
                    CssClass="ft_black" Text="Continue without registration" Width="200px"></asp:Label>
                <asp:Button ID="Button3" runat="server" CssClass="button" Text="Just Apply" OnClick="Button3Click" />
            </div>
        </div>
        
    </div>
    <div class="dv_fix">
    </div>
    <!--end divs-->
</asp:Content>