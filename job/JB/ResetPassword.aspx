<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="ResetPassword.aspx.cs" Inherits="JB.Resetpassword" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
     
        <asp:Label ID="Label13" runat="server" Text="Password change in progress" CssClass="ft_whitebd"></asp:Label>
         
    </div>
    <div class="boxcorner">
        <div class="dv_globalmiddle">
            <div class="rstpwdcenterhg">
            </div>
            <div class="rstpwdtextmid">
             <div class="ft_notify">
                    <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_fixx4">
                </div>

             
                <asp:Label ID="Label1" runat="server" Text="Email Address" CssClass="ft_black"></asp:Label>
                 
                
            </div>
            <div class="ln_fixx4">
            </div>
            <div>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSt"></asp:TextBox>
                <asp:TextBoxWatermarkExtender ID="TextBox1_TWE" runat="server" Enabled="True" TargetControlID="TextBox1"
                    WatermarkCssClass="TextboxSttwe" WatermarkText="like someone@example.com">
                </asp:TextBoxWatermarkExtender>
            </div>
            
            <div>
             
                <asp:CheckBox ID="CheckBox1" runat="server" CssClass="ft_black" Text="I am a recruiter" />
                 
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx8">
            </div>
            <div id="resetpwdwrapline">
                <div class="ln_ccc">
                </div>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
             
            
                 
            <div class="dv_fix">
            </div>
            <div class="ln_fixx2">
            </div>
            <div>
             
                <asp:Button ID="Button1" runat="server" Text="Reset" CssClass="button" OnClick="Button1Click" />
                &nbsp;<asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" CausesValidation="False"
                    OnClick="Button2Click" />
             
            </div>
            <div class="dv_fix">
            </div>
            <br />
        </div>
    </div>
</asp:Content>