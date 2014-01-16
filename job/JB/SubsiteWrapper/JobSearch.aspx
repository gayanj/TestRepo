<%@ Page Title="" Language="C#" MasterPageFile="~/SubsiteWrapper/Subsite.Master"
    AutoEventWireup="true" CodeBehind="JobSearch.aspx.cs" Inherits="JB.SubsiteWrapper.Jobsearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="LeftSideBar" runat="server" Visible="false">
    </asp:Panel>
    <asp:Panel ID="SearchCenter" runat="server">
        <asp:GridView ID="GridJobs" runat="server">
        </asp:GridView>
    </asp:Panel>
    <asp:Panel ID="RightSideBar" runat="server" Visible="false">
    </asp:Panel>
</asp:Content>
