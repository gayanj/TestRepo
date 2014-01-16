<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecCvSearch.aspx.cs" Inherits="JB.Recruiters.Reccvsearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label5" runat="server" CssClass="ft_white" Text="Search Resumes"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Search candidate resumes, simple and fast way to go through candidates details
        </div>
    </div>
    <div class="time_right">
        <div id="rc_searchresmid">
            <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Free for limited time*"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxsearch" CssClass="TextboxStylerecs" runat="server" MaxLength="255"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx1">
            </div>
            <asp:Button ID="Buttonsearch" runat="server" CssClass="button" Text="Search CV's"
                OnClick="ButtonsearchClick" />
            <br />
            <asp:GridView ID="GridViewResults1" runat="server" AutoGenerateColumns="False" GridLines="None"
                BorderWidth="0px" AllowPaging="True" EmptyDataText="No Resume Found with your criteria"
                EmptyDataRowStyle-CssClass="ft_black" Width="100%">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div class="ln_ccc">
                            </div>
                            <div class="ln_fixx4">
                            </div>
                            <img alt="cvsearch" src="/images/wordresume.gif" />
                            <br />
                            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_bluebldwnodeco" NavigateUrl='<%# Eval("dtdocpath") %>'
                                Text="Open Resume"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle CssClass="PagerStyle" />
            </asp:GridView>
            <asp:Label ID="LabelOutput" runat="server" Text="" CssClass="ft_black"></asp:Label>
            <br />
        </div>
    </div>
</asp:Content>
