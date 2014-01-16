<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="Answer.aspx.cs" Inherits="JB.Helpcenter.Answer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function showdivs(dvhids) {
            document.getElementById(dvhids).style.display = "";
            return false;
        }

        function hidedivs(dvsids) {
            document.getElementById(dvsids).style.display = "none";
        }

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Help Center
        </div>
    </div>
    <div class="boxcorner">
        <br />
        <div class="hlp_ansl3">
            <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Does the information on your right resolves your issue"></asp:Label>
            <br />
            <asp:Button ID="Buttonh1" runat="server" CssClass="button" Text="YES" OnClick="ButtonyesClick" />
            &nbsp;<asp:Button ID="Buttonh2" runat="server" CssClass="button" Text="NO" OnClientClick="return showdivs('hlp_categorydm1');" />
            <br />
            <br />
            <div id="hlp_categorydm1">
                <div class="ln_ccc">
                </div>
                <br />
                <asp:Label ID="Label2" CssClass="ft_black" runat="server" Text="Ok, so what you want to do now"></asp:Label>
                <br />
                <asp:Button ID="Buttonh3" runat="server" CssClass="button" Text="Contact us" OnClick="Buttonh3Click" />
                &nbsp;
                <asp:Button ID="Button4" runat="server" CssClass="button" Text="Search Again" OnClick="Button4Click" />
            </div>
        </div>
        <div class="hlp_ansl2">
            <asp:Label ID="Labelqs" runat="server" CssClass="ft_orangeh1" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="Labelans" runat="server" CssClass="ft_gray" Text=""></asp:Label>
        </div>
    </div>
    <script type="text/javascript">
        hidedivs('hlp_categorydm1');
    </script>
</asp:Content>