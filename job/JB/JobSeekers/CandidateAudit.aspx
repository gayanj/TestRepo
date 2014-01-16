<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="CandidateAudit.aspx.cs" Inherits="JB.Jobseekers.Candidateaudit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="Login Audit" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Keep track of who accesed your account! use our enterprise tool, it's build for
            you.</div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" GridLines="Horizontal"
                BorderWidth="0px" Width="100%" ShowHeader="False">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="Label28" runat="server" CssClass="ft_black" Text="Accessed on "></asp:Label>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("logindate", "{0:dd/M/yyyy}") %>'
                                CssClass="ft_blackbd"></asp:Label>
                            <asp:Label ID="Label29" runat="server" CssClass="ft_black" Text=" at "></asp:Label>
                            <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("logintime") %>'></asp:Label>
                            <asp:Label ID="Label30" runat="server" CssClass="ft_black" Text=" from ip "></asp:Label>
                            <asp:Label ID="Label3" runat="server" CssClass="ft_blackbd" Text='<%# Bind("userip") %>'></asp:Label>
                            <asp:Label ID="Label31" runat="server" CssClass="ft_black" Text=" using device "></asp:Label>
                            <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("userdevice") %>'></asp:Label>
                            <div class="ln_ccc">
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>