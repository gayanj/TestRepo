<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="CanApplication.aspx.cs" Inherits="JB.Jobseekers.Canapplication" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .dv_candiapp { width: 400px; margin: 0 auto; }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="cn_header">
        <asp:Label ID="Label11" runat="server" CssClass="ft_white" Text="Application in progress..."></asp:Label>
    </div>
    <div class="dv_candiapp">
        <br />

        <div class="ft_notify">
            <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
        </div>

        <br />
        <img alt="Use new resume" src="/images/nm_one.gif" />
        <asp:Label ID="Label15" runat="server" CssClass="ft_black" Text="Please choose your resume here"></asp:Label>
        <br />
        <br />
        <div class="dv_fix">
        </div>
        
            <asp:Label ID="Label16" runat="server" CssClass="ft_black" Text="Covering Letter"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" Height="100px" TextMode="MultiLine"
                Width="100%" Wrap="true"></asp:TextBox>
        
        <div class="dv_fix">
        </div>
        <div class="ln_ccc">
        </div>
        
            <asp:Label ID="Label17" runat="server" CssClass="ft_black" Text="Upload CV"></asp:Label>
            <br />
            <asp:FileUpload ID="FileUpload1" runat="server" Width="300px"  CssClass="ft_black" />
        <br />    
        <asp:Label ID="Label18" runat="server" CssClass="ft_black" Text="Only support *.docx, *.pdf, *.doc and less than 500kb"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="" CssClass="ft_red"></asp:Label>
        
        <div class="dv_fix">
        </div>
        <br />
        <div>
            <div class="ln_fixx10">
            </div>
            <div id="applicationsleft">
            </div>
            <div id="applicationsmiddle">
                OR
            </div>
            <div id="applicationsright">
            </div>
        </div>
        <div class="dv_fix">
        </div>
        <img alt="Use existing resume" src="/images/nm_two.gif" />
        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="ft_black" Text="Use a resume on file" />
        <div class="dv_fix">
        </div>
        <div class="ln_ccc">
        </div>
        <div class="ln_fixx4">
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" CssClass="button" Text="Submit" OnClick="Button2Click" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" CssClass="button" Text="Cancel" OnClick="Button3Click"
                CausesValidation="False" />
        </div>
        <div class="dv_fix">
        </div>
        <asp:Label ID="Label19" runat="server" CssClass="ft_black"></asp:Label>
        <div class="dv_fix">
        </div>
        <br />
        <br />
        <br />
    </div>
</asp:Content>
