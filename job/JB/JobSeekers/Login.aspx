<%@ Page Title="" Language="C#" MasterPageFile="~/Logins.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="JB.Jobseekers.Login" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="lg_midalg">
        <div class="msg_notify">
            <asp:Label ID="LabelNotify" runat="server" Text="" CssClass="ft_black"></asp:Label>
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_fixx4"></div>
        <asp:Label ID="Label10" runat="server" CssClass="ft_black" Text="Email Address"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" Width="200px" MaxLength="255"></asp:TextBox>
        <br />
        <asp:Label ID="Label11" Width="45px" runat="server" CssClass="ft_black" Text="Password"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" CssClass="TextboxSt"
            Width="200px" MaxLength="45"></asp:TextBox>
        <div class="dv_fix">
        </div>
        <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2Click" CssClass="button" />
        &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Cancel" OnClick="Button3Click" CssClass="button"
            CausesValidation="False" />
        <br />
        <div class="ln_fixx6">
        </div>
        <div class="lg_leftor">
        </div>
        <div class="lg_midor">
            <div class="ft_gray">
                or</div>
        </div>
        <div class="lg_rightor">
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_fixx6">
        </div>
        <a href="/resetpassword" class="ft_bluelink">I forgot my password</a>        
        <div class="dv_fix">
        </div>
        <div class="ln_fixx6">
        </div>
        <div class="lg_leftor">
        </div>
        <div class="lg_midor">
            <div class="ft_gray">
                or</div>
        </div>
        <div class="lg_rightor">
        </div>
        <div class="dv_fix">
        </div>
        <div class="ln_fixx6">
        </div>
        <div class="ft_black">
            I don't have an account yet!</div>
        <div class="ln_fixx6">
        </div>
        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="button" OnClick="LinkButton2Click"
            CausesValidation="False"> Register Now! </asp:LinkButton>
        <br />
        <br />
        <br />
    </div>
</asp:Content>
