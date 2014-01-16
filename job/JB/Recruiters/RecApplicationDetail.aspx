<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecApplicationDetail.aspx.cs"
    Inherits="JB.Recruiters.Recapplicationdetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/styles/pheonixv1.css" rel="stylesheet" type="text/css" />
    <link href="/styles/pheonixgrid.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="JobSeeker profile" CssClass="tb_headtwo"></asp:Label>
    <div class="dv_fix">
    </div>
    <div class="ln_444">
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <asp:Label ID="Label2" runat="server" CssClass="ft_gray444"></asp:Label>
    <br />
    <br />
    <asp:Label ID="LabelDetails" runat="server" CssClass="tb_headtwo" Text="Candidate Details"></asp:Label>
    <div class="dv_fix">
    </div>
    <div class="ln_444">
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelFName" runat="server" CssClass="ft_black" Text="First Name"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowFName" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelLName" runat="server" CssClass="ft_black" Text="Last Name"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowLName" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelAddress1" runat="server" CssClass="ft_black" Text="Address Line 1"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowAddress1" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelAddress2" runat="server" CssClass="ft_black" Text="Address Line 2"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowAddress2" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelAddress3" runat="server" CssClass="ft_black" Text="Address Line 3"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowAddress3" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelTown" runat="server" CssClass="ft_black" Text="Town"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowTown" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelCounty" runat="server" CssClass="ft_black" Text="County"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowCounty" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelCountry" runat="server" CssClass="ft_black" Text="Country"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowCountry" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelPostCode" runat="server" CssClass="ft_black" Text="PostCode"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowPostCode" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelHomePhone" runat="server" CssClass="ft_black" Text="Home Tel"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowHomePhone" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
    <div class="w20">
        <asp:Label ID="LabelWorkPhone" runat="server" CssClass="ft_black" Text="Work Tel"></asp:Label>
    </div>
    <div class="w50">
        <asp:Label ID="LabelShowWorkPhone" runat="server" CssClass="ft_gray" Text="Private"></asp:Label>
    </div>
    <br />
     <asp:Label ID="Label3" runat="server" CssClass="tb_headtwo" Text="Question Answers"></asp:Label>
    <div class="dv_fix">
    </div>
    <div class="ln_444">
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <!-- if any questions show answers -->
    <asp:Panel ID="PanelQuestions" runat="server">
    </asp:Panel>
    <br />
    <asp:Label ID="LabelDetails0" runat="server" CssClass="tb_headtwo" Text="Download Resumes"></asp:Label>
    <div class="dv_fix">
    </div>
    <div class="ln_444">
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="ft_bluelink">Download</asp:HyperLink>
    </form>
</body>
</html>
