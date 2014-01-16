<%@ Page Title="" Language="C#" MasterPageFile="~/Facebook/Facebook.Master" AutoEventWireup="true" CodeBehind="InviteContacts.aspx.cs" Inherits="JB.Facebook.InviteContacts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rightpan">
        <div id="addjobform">
            <div class="ux_top">
                <div class="ux_innershim">
                    <br />
                    <div class="w100">
                        <label class="afont">Email Address:</label>
                    </div>
                    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
                    <div class="w100">
                        <label class="afont">Subject:</label>
                    </div>
                    <asp:TextBox ID="TextBoxSubject" runat="server"></asp:TextBox>
                    <div class="ux_clear"></div>
                    <div class="w100">
                        <label class="afont">Messege:</label>
                    </div>
                    <asp:TextBox ID="TextBoxMsg" runat="server" TextMode="MultiLine" CssClass="ux_textbox"></asp:TextBox>                    
                    <br />
                    <div class="ux_rightitem">
                        <asp:Button ID="Button1" runat="server" Text="Send Mail" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
