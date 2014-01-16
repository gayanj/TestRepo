<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="JobVideos.aspx.cs" Inherits="JB.Recruiters.Jobvideos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <script type="text/javascript">
        function showdivs(a) {
            $('#' + a).show();
        }

        function hidedivs(a) {
            $('#' + a).hide();
        }

        function setvid() {
            var tempcdiv = document.getElementById('<%= this.CheckBoxvid.ClientID %>');
            if (tempcdiv.checked == true) {
                showdivs('dv_jformvid');
            }

            else {
                hidedivs('dv_jformvid');
            }
        }

        $(document).ready(function () {
            hidedivs('dv_jformvid');
        });

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label14" runat="server" CssClass="ft_white" Text="Post Jobs"></asp:Label>
    </div>
    <div class="bg_black">
        <div class="ft_white">
            Step 2 of 3
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <div id="rc_vidmid">
        <asp:CheckBox ID="CheckBoxvid" runat="server" Text="Attach Video" CssClass="ft_black"
            onclick="setvid();" />
        <div class="ln_fixx8">
        </div>
        <div id="dv_jformvid">
            <div class="dv_fix">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Labelvidtitle" runat="server" Text="Video Title" CssClass="ft_black"></asp:Label>
            </div>
            <asp:TextBox ID="TextBoxvidtitle" CssClass="TextboxStylerecs" runat="server" MaxLength="255"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Labelvidurl" runat="server" Text="Video URL" CssClass="ft_black"></asp:Label>
            </div>
            <asp:TextBox ID="TextBoxvidurl" CssClass="TextboxStylerecs" runat="server" MaxLength="500"></asp:TextBox>
            <br />
            <div class="ln_fixx8">
            </div>
            <div class="ln_ccc">
            </div>
            <div class="ln_fixx8">
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="Save and Continue"
            OnClick="Button1Click" />
        <div class="dv_fix">
        </div>
        <br />
    </div>
</asp:Content>
