<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbWebsiteWidget.aspx.cs" Inherits="JB.Jbwebsitewidget" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Website Widget
        </div>
    </div>
    <div class="boxcorner">
        <div class="ft_backhighh1">
            Get the jobs that you like straight to your website!*
        </div>
        <br />
        <div class="dvleft">
            <img alt="Website Widgets" src="/images/bg_webwidget.png" />
        </div>
        <div class="jbwebsiteleftbar">
        </div>
        <div class="dvleft">
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
            <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text="Tell us a little bit about yourself and get your widget."></asp:Label>
            <br />
            <br />
            <img src="/images/nm_one.gif" alt="One" />
            <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Selecting a theme from list "></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Aqua</asp:ListItem>
                <asp:ListItem>Rose</asp:ListItem>
                <asp:ListItem>Dewgreen</asp:ListItem>
                <asp:ListItem>Soil</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <img id="img1" src="/images/nm_two.gif" alt="Two" />
            <asp:Label ID="Label4" runat="server" Text="Company Name" CssClass="ft_black"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <br />
            <br />
            <img id="img2" src="/images/nm_three.gif" alt="Three" />
            <asp:Label ID="Label5" runat="server" Text="Company's Core Business"
                CssClass="ft_black"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <br />
            <br />
            <img id="img3" src="/images/nm_four.gif" alt="Four" />
            <asp:Label ID="Label6" runat="server" Text="First Name" CssClass="ft_black"></asp:Label>
            &nbsp;&nbsp;<br />
            <asp:TextBox ID="TextBox4" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <br />
            <br />
            <img id="img4" src="/images/nm_five.gif" alt="Five" />
            <asp:Label ID="Label7" runat="server" Text="Last Name" CssClass="ft_black"></asp:Label>
            &nbsp;&nbsp;<br />
            <asp:TextBox ID="TextBox5" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <br />
            <br />
            <img id="img5" src="/images/nm_six.gif" alt="Six" />
            <asp:Label ID="Label8" runat="server" Text="Telephone" CssClass="ft_black"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="TextBox6" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <br />
            <br />
            <img id="img6" src="/images/nm_seven.gif" alt="Seven" />
            <asp:Label ID="Label9" runat="server" Text="Website" CssClass="ft_black"></asp:Label>
            &nbsp;<br />
            <asp:TextBox ID="TextBox7" runat="server" CssClass="TextboxSt"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Get my jobsite" CssClass="button" OnClick="Button1Click" />
        </div>
        <asp:Panel ID="Paneljbdtpreview" runat="server" Visible="false">
        </asp:Panel>
        <div class="dv_fix">
        </div>
    </div>
</asp:Content>
