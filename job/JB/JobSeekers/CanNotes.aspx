<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true" CodeBehind="CanNotes.aspx.cs" Inherits="JB.Jobseekers.Cannotes" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .cannoteslft { width: 300px; }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="cn_header">
        <asp:Label ID="Label1" runat="server" CssClass="ft_white" Text="My Notes"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Take notes of important reminders etc when you
            <br />
            speak to the recruiters
        </div>
    </div>
    <div class="time_right">
        <div class="jseekermidback">
            <div class="cannoteslft">
                <div class="ft_notify">
                    <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <br />
                <div class="ft_graybd">
                    Scratch Pad
                </div>
                <div class="ln_fixx8">
                </div>
                <asp:TextBox ID="Editor1" runat="server" CssClass="ft_black aligntop notewidth" TextMode="MultiLine"></asp:TextBox>
                <div class="ln_fixx8">
                </div>
                <asp:Button ID="Updatenotebutton" CssClass="button" runat="server" Text="Save" OnClick="UpdatenotebuttonClick" />
            </div>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
