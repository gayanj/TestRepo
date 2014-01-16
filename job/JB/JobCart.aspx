<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JobCart.aspx.cs" Inherits="JB.Jobcart" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <!-- top bar -->
    <div class="divsimpletop">
     
        <div class="ft_whitebd">
            Saved jobs</div>
             
    </div>
    <div class="boxcorner">
        <asp:Panel ID="Panelmessage" runat="server" Visible="false">
         
            <div class="confirmstyle">
                <asp:Label ID="LabelEmptyCart" CssClass="ft_white" runat="server" Text="You have no saved jobs!"></asp:Label>
            </div>
             
        </asp:Panel>
        <div class="jobcartcenter">
            <div class="ln_fixx10">
            </div>
            <div class="dv_fix">
            </div>
             
            <asp:Panel ID="jbdynapanel" CssClass="jobcartleft" runat="server">
            </asp:Panel>
             
            <div class="dv_fix">
            </div>
            <div class="ln_fixx10">
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx10">
            </div>
             
            <asp:Panel ID="jbcartpanel" CssClass="jobcartleft" runat="server">
                <asp:Button ID="jbClear" CssClass="button" runat="server" Text="Remove All" OnClick="JbClearClick" />&nbsp;
            </asp:Panel>
             
        </div>
    </div>
</asp:Content>