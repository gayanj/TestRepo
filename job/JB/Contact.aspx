<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="Contact.aspx.cs" Inherits="JB.Contact" %>

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
            contact information
        </div>
        
    </div>
    <div class="boxcorner">
        
        <div id="divftsleft100">
            <asp:Label ID="Label16" runat="server" CssClass="ft_backhighh1" Text="So that we can answer your queries in a timely fashion please email one of the contacts listed below, however we strongly advise visiting our help center first"></asp:Label>
            <br />
            <br />
            <div class="dv_fix">
            </div>
            <div class="ct_conmainl1">
                <asp:Label ID="Label1" runat="server" CssClass="ft_blackh2" Text="Use our help center to answer most of your questions "></asp:Label>
            </div>
            <div class="ct_conmainl2">
                <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="or if your query is a high priority based, email us directly "></asp:Label><br />
                <asp:HyperLink ID="HyperLink7" runat="server" CssClass="ft_silverh1" NavigateUrl="mailto:info@fashionquadrant.com">info@fashionquadrant.com</asp:HyperLink>
            </div>
        </div>
        
    </div>
</asp:Content>
