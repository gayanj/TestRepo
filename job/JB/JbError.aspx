<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbError.aspx.cs" Inherits="JB.Jberror" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
        
            error
            
        </div>
    </div>
    <div class="boxcorner">
        <div class="confirmstyle">
            <div class="ft_white">
            
                Oops! an unknown error has occured but we are working on it, please check back later...
                
            </div>
        </div>
        <br />
        <br />
        <br />
    </div>
</asp:Content>