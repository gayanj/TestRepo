<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbEmailPage.aspx.cs" Inherits="JB.Jbemailpage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Jobs forward email in progress            
        </div>
    </div>
    <div class="boxcorner">
        <div class="jb_emailtopcover">
            <br />
            <br />
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
            <div class="jb_emailsendleft">
                <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Your Email"></asp:Label>
            </div>
            <div class="jb_emailsendright">
                <asp:TextBox ID="fromaddress" CssClass="TextboxSt" runat="server"></asp:TextBox>
            </div>
            <br />
            <br />
            
            <div class="jb_emailsendleft">
                <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text="Friends Email"></asp:Label>
            </div>
            <div class="jb_emailsendright">
                <asp:TextBox ID="toaddress" CssClass="TextboxSt" runat="server"></asp:TextBox>
            </div>
            <br />
            <br />
           
            <div class="jb_emailsendleft">
                <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text="Messege"></asp:Label>
            </div>
            <div class="jb_emailsendright">
                <asp:TextBox ID="emailmsg" CssClass="TextboxSt" runat="server" Rows="4" Height="100"
                    TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>            
            <div class="ln_ccc">
            </div>
            <div class="jb_emailfootcover">
                <asp:Button ID="Button1" runat="server" CssClass="button" Text="Send" OnClick="Button1Click" />
                &nbsp;<asp:Button ID="Button2" runat="server" CssClass="button" Text="Cancel" OnClick="Button2Click1"
                    CausesValidation="False" />
            </div>
        </div>

    </div>
</asp:Content>
