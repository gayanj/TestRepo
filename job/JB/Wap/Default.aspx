<%@ Page Title="" Language="C#" MasterPageFile="~/wap/wap.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="JB.wap.Default" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="m_pagewrap">
        <div class="m_searchcover">
            <asp:TextBox ID="searchtext" CssClass="m_textboxmain" AutoCompleteType="None" runat="server"
                MaxLength="255"></asp:TextBox>
            <asp:Button ID="searchbutton" CssClass="ux_wpsearchbutton" runat="server" Text="Search"
                OnClick="searchbutton_Click" />
        </div>
        <br />
        <div class="m_dv_fix">
        </div>
        <div class="m_pgdefault_center">
            OR
        </div>
        <div class="m_dv_fix">
        </div>
        <br />
        <div class="m_bt_wrapper">
            <asp:Button ID="Browse1" CssClass="m_button" runat="server" Width="100%" Text="Browse by Categories"
                OnClick="Browse1_Click" />
        </div>
        <br />
    </div>
</asp:Content>
