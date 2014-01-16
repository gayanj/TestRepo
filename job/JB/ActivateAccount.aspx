<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true" CodeBehind="ActivateAccount.aspx.cs" Inherits="JB.ActivateAccount" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixv3.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            EULA</div>
    </div>
    <div class="boxcorner">
    
        <asp:Panel ID="Panel1" runat="server">
            <div class="dv_docgenrics">
                <br />
                <div class="smap_lefts">
                    EULA
                </div>
                <div class="dv_fix">
                </div>
                <div class="tb_headone">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ln_444">
                </div>
                <div class="dv_fix">
                </div>
                <div class="ft_blackjust">
                    <br />
                    Updated: 5.3.2011
                    <br />
                    <br />
                    Please note that by using our service/services you hereby agree to the conditions
                    set underlines here or in a brief set at http://fashionquadrant.com/terms. Also the terms
                    listed here may not reflect the full context of the usage policy (a detailed list
                    of this policy can be obtained by a general request email). Articles in the context
                    could be any piece of information either text, picture which can be information
                    / non-informational.
                    <br />
                    1- You will not use any means or services both internal and external which may or
                    can harm our system or any of its resources.<br />
                    2- You agree to provide the information which can or might be shared on the public
                    domain.
                    <br />
                    3- You will not upload any documents or material which discriminates in either racial,
                    sexual, religious or any other specific means.<br />
                    4- You will not upload any of the documents which again can harm the system with
                    respect to clause 1. We do scan documents uploaded into our system and if any piece
                    of document or artifacts contains any bindings which we may think can harm our system
                    we reserve the right to delete it without prior warning.<br />
                    5- If any material is found offensive it would be deleted immediately by our system
                    without any prior notice.<br />
                    6- You are advised to make all backup copies of your data before uploading it to
                    our domain. This is for your own benefit. We will not be responsible for loss of
                    any data which occurs on our domain.<br />
                    7- Please do not use our system as a backup of your data as described in clause
                    .6.
                    <br />
                    8- We try to offer a fully transparent system and do not miss-use any information
                    which we retain in our system either from jobseekers or recruiters. We would appreciate
                    if you would do the same.<br />
                    9- We look into our user’s privacy with a keen eye and would encourage you to do
                    the same.
                    <br />
                </div>
                <div class="dv_fix">
                </div>
                <br />
                <div class="ln_444">
                </div>
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" CssClass="ft_black" RepeatDirection="Horizontal"
                    RepeatLayout="Flow">
                    <asp:ListItem Value="1">I Agree</asp:ListItem>
                    <asp:ListItem Value="0">I Disagree</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1Click"
                    Text="Activate Account" />
                <br />
                <br />
            </div>
        </asp:Panel>
    
    </div>
</asp:Content>
