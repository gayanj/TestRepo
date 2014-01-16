<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecUsers.aspx.cs" Inherits="JB.Recruiters.RecUsers" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="Users linked to this recruiter"></asp:Label>
    </div>
    <div class="cn_appdvleft">
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True"
            CssClass="ft_black" DataKeyNames="idUsers" OnRowEditing="GridView1RowEditing"
            Width="100%">
            <Columns>
                <asp:BoundField DataField="uUserName" HeaderText="UserName" />
                <asp:BoundField DataField="uFirstName" HeaderText="FirstName" />
                <asp:BoundField DataField="uLastName" HeaderText="LastName" />
                <asp:BoundField DataField="uIsPrimary" HeaderText="MainUser" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
</asp:Content>