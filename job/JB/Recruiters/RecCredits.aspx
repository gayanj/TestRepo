<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecCredits.aspx.cs" Inherits="JB.Recruiters.Reccredits" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label5" runat="server" CssClass="ft_white" Text="Credits Availability"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <div class="time_left">
                <div class="ft_black">
                    Keep track of your upsells, through a simple clean and easy to use display.</div>
            </div>
            <div class="time_right">
                <div class="rc_creditmid">
                    <div class="rc_creditleft">
                        <asp:Label ID="LabelAvailableCredit" runat="server" CssClass="ft_black" Text=""></asp:Label>
                    </div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton1" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton1Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="Labelloginpageadvert" runat="server" Text="You have [0] credits left from <b>Silver job ad pack</b>"
                            CssClass="ft_black"></asp:Label></div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton2" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton2Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="Labelsponsoredjobs" runat="server" Text="You have [0] credits left from <b>Platinum job ad pack</b>"
                            CssClass="ft_black"></asp:Label>
                    </div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton3" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton3Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="Label1" runat="server" Text="You have [0] credits left from <b>Recruiter of the week ad pack</b>"
                            CssClass="ft_black"></asp:Label>
                    </div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton4" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton4Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="LabelRecruiterofweek" runat="server" Text="You have [0] credits left from <b>All site banner ad pack</b>"
                            CssClass="ft_black"></asp:Label></div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton5" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton5Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="LabelLoginMicroads" runat="server" Text="You have [0] credits left from <b>Login silver job ad pack</b>"
                            CssClass="ft_black"></asp:Label>
                    </div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton6" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton6Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="Label2" runat="server" Text="You have [0] credits left from <b>Login micro job ad pack</b>"
                            CssClass="ft_black"></asp:Label></div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton7" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton7Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_ccc">
                    </div>
                    <div class="rc_creditleft">
                        <asp:Label ID="Label3" runat="server" Text="You have [0] credits left from <b>Home page stock bar ad pack</b>"
                            CssClass="ft_black"></asp:Label></div>
                    <div class="rc_creditrigth">
                        <asp:LinkButton ID="LinkButton8" CssClass="ft_bluelinkwnodeco" runat="server" OnClick="LinkButton8Click">buy more...</asp:LinkButton>
                    </div>
                    <div class="dv_fix">
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>