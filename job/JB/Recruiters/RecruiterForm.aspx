<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecruiterForm.aspx.cs" Inherits="JB.Recruiters.RecruiterForm" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>


    <div class="rc_header">
        <asp:Label ID="Label28" runat="server" CssClass="ft_white" Text="Profile"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Bio data for maintaining a current contact with us or candidates.
        </div>
    </div>
    <div id="rf" class="time_right">
        <div class="rc_recformmid">
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <br />
            <div class="tb_headtwo">Recruiter Details</div>
            <div class="dv_fix"></div>
            <div class="ln_444"></div>
            <br />
            <div class="cn_appdvleft">
                <asp:Label ID="Label10" runat="server" CssClass="ft_black" Text="First Name"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxStylerecs" MaxLength="255"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label11" runat="server" CssClass="ft_black" Text="Last Name"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxStylerecs" MaxLength="255"></asp:TextBox>
            </div>
            <br />
            <br />
            <div class="tb_headtwo">Contact Details</div>
            <div class="dv_fix"></div>
            <div class="ln_444"></div>
            <br />
            <div class="cn_appdvleft">
                <asp:Label ID="Label12" runat="server" CssClass="ft_black" Text="Address1"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="TextboxStylerecs" MaxLength="500"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label13" runat="server" CssClass="ft_black" Text="Address2"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="TextboxStylerecs" MaxLength="500"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label14" runat="server" CssClass="ft_black" Text="Address3"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="TextboxStylerecs" MaxLength="500"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label15" runat="server" CssClass="ft_black" Text="Town"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="TextboxStylerecs" MaxLength="45"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label16" runat="server" CssClass="ft_black" Text="County"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox8" runat="server" CssClass="TextboxStylerecs" MaxLength="45"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label17" runat="server" CssClass="ft_black" Text="Post Code"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox9" runat="server" CssClass="TextboxStylerecs" MaxLength="10"></asp:TextBox>
            </div>
            <br />
            <br />
            <div class="tb_headtwo">Business Details</div>
            <div class="dv_fix"></div>
            <div class="ln_444"></div>
            <br />
            <div class="cn_appdvleft">
                <asp:Label ID="Label23" runat="server" CssClass="ft_black" Text="Company Name"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox10" runat="server" CssClass="TextboxStylerecs" MaxLength="100"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label26" runat="server" CssClass="ft_black" Text="Company Website"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox15" runat="server" CssClass="TextboxStylerecs" MaxLength="500"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <div class="cn_appdvleft">
                <asp:Label ID="Label27" runat="server" CssClass="ft_black" Text="Company Intro"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox16" runat="server" CssClass="TextboxStylerecs" Height="50px"
                    TextMode="MultiLine" Wrap="True" MaxLength="255"></asp:TextBox>
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="cn_appdvleft">
                <asp:Label ID="Label25" runat="server" CssClass="ft_black" Text="Business Detail"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:TextBox ID="TextBox14" CssClass="TextboxStylerecs" Height="300" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="dv_fix"></div>
            <br />
            <div class="cn_appdvleft">
                <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text="Account Type"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropdwndayrange">
                    <asp:ListItem Selected="True" Value="0">Direct</asp:ListItem>
                    <asp:ListItem Value="1">Agency</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <br />
            <div class="tb_headtwo">Branding</div>
            <div class="dv_fix"></div>
            <div class="ln_444"></div>
            <br />
            <div class="cn_appdvleft">
                <asp:Label ID="Label22" runat="server" CssClass="ft_black" Text="CompanyLogo"></asp:Label>
            </div>
            <div class="cn_appdvright">
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <br />
                <asp:Image ID="Image8" runat="server" Height="75px" Width="75px" ImageUrl="~/Images/nopic.gif" />
            </div>
            <div class="dv_fix">
            </div>
            <asp:Button ID="Button2" runat="server" Text="Save" CssClass="button" OnClick="Button2Click" />
            &nbsp;
                <asp:Button ID="Button3" runat="server" Text="Cancel" CssClass="button" OnClick="Button3Click"
                    CausesValidation="False" />
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
