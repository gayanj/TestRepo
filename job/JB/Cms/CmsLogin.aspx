<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CmsLogin.aspx.cs" Inherits="JB.Cms.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="/styles/pheonixl1.css" rel="stylesheet" type="text/css" />
    <link href="/styles/pheonixv1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="cms_loginmid">
            <div class="cmsloginblack">
                <br />
                <div class="cmslogoset">
                    <img alt="Login Logo" src="/Brandimages/brand_cmslogin.png" />
                </div>
                <br />
                <div class="msg_notify">
                    <asp:Label ID="LabelNotify" runat="server" Text="" CssClass="ft_black"></asp:Label>
                </div>
                <div class="dv_fix"></div>
                <div class="cmslogininner">
                    <div class="cms_loginerror">
                        <asp:Label ID="LabelMessage" runat="server" Text="" CssClass="ft_red" Visible="False"></asp:Label>
                    </div>
                    <div class="cms_logintxtwrap">
                        <label for="usn" class="ft_silver">Username</label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2"
                            CssClass="ft_red" ErrorMessage="required"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSt" Width="290" MaxLength="50"></asp:TextBox>
                    </div>
                    <div class="ln_fixx4">
                    </div>
                    <div class="cms_logintxtwrap">
                        <label for="pwds" class="ft_silver">Password</label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3"
                            CssClass="ft_red" ErrorMessage="required"></asp:RequiredFieldValidator>
                        <br />
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" CssClass="TextboxSt" Width="290" MaxLength="50"></asp:TextBox>
                    </div>
                    <br />
                    <!-- buttons-->
                    <div class="cms_loginbtnwrap">
                        <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" CssClass="button" />
                        &nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Cancel" OnClick="Button3_Click" CssClass="button"
                        CausesValidation="False" />
                    </div>
                    <br />
                </div>
            </div>
        </div>
        <div class="cms_loginbottom">
            <asp:Label ID="LabelVersion" runat="server" Text="CMS Version: 3.0.2" CssClass="ft_silver"></asp:Label>
        </div>
    </form>
</body>
</html>
