<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="ReportaPage.aspx.cs" Inherits="JB.Reportapage" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
     
        <asp:Label ID="Label1" runat="server" CssClass="ft_whitebd" Text="spam enquiry"></asp:Label>
         
    </div>
    <div class="boxcorner">
        <div class="dv_docgenrics">
            <br />
            <div class="ft_black">
             
                What do you thing was wrong with this page...
                 
                </div>

            <br />
            <div class="dv_fix">
            </div>
             
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="ft_black" RepeatLayout="Flow">
                <asp:ListItem Value="1" Selected="True">this page had voilent contents</asp:ListItem>
                <asp:ListItem Value="2">this page shows racism to any race</asp:ListItem>
                <asp:ListItem Value="3">this page has fake recruiter</asp:ListItem>
                <asp:ListItem Value="4">this is my company, someone else if pretending to be me...</asp:ListItem>
            </asp:RadioButtonList>
            
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="if none of the above please fill in the text box below."></asp:Label>
            <br />
             
            <br />
            <asp:TextBox ID="spamreasons" runat="server" CssClass="TextboxSt" Width="310px"></asp:TextBox><br />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="button" Text="Report" OnClick="Button1Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" CssClass="button" Text="Cancel" OnClick="Button2Click" />
        </div>
    </div>
</asp:Content>