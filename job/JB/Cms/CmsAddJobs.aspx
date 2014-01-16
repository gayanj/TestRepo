<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true" CodeBehind="CmsAddJobs.aspx.cs" Inherits="JB.Cms.CmsAddJobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Adding Job" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>
    <br />
    <div class="ux_cm_left">
        <label for="JTitle" class="ft_black">Job Title</label>
        <br />
        <asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for="JShortDesc" class="ft_black">Job Short Description</label>
        <br />
        <asp:TextBox ID="TextBoxShortDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <label for="JDesc" class="ft_black">Job Description</label>
        <br />
        <asp:TextBox ID="TextBoxDesc" runat="server" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        <label for="JPostingStart" class="ft_black">Start Date</label>
        <br />
        <asp:TextBox ID="StartDate1" runat="server" MaxLength="2" Width="50px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="StartDate2" runat="server" MaxLength="2" Width="50px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="StartDate3" runat="server" MaxLength="4" Width="100px"></asp:TextBox>
        <br />
        <br />
        <label for="JPostingStart" class="ft_black">End Date</label>
        <br />
        <asp:TextBox ID="EndDate1" runat="server" MaxLength="2" Width="50px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="EndDate2" runat="server" MaxLength="2" Width="50px"></asp:TextBox>
        &nbsp;<asp:TextBox ID="EndDate3" runat="server" MaxLength="4" Width="100px"></asp:TextBox>
        <br />
        <br />
        <label for="JSalaryText" class="ft_black">Salary Text</label>
        <br />
        <asp:TextBox ID="TextBoxSal" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for="JJobRef" class="ft_black">Job Ref#</label>
        <br />
        <asp:TextBox ID="TextBoxRefno" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for="JJobLocation" class="ft_black">Location</label>
        <br />
        <asp:TextBox ID="TextBoxLoc" runat="server"></asp:TextBox>
        <br />
        <br />
        <label for="JJobRec" class="ft_black">Recruiters</label>
        <br />
        <asp:DropDownList ID="DropDownListRecruiters" runat="server"></asp:DropDownList>
        <br />
        <br />
        <label for="JJobCurr" class="ft_black">Currency</label>
        <br />
        <asp:DropDownList ID="Currency" runat="server" CssClass="dropdwn1">
            <asp:ListItem Value="GBP" Selected="True">£ | GBP</asp:ListItem>
            <asp:ListItem Value="USD">$ | USD</asp:ListItem>
            <asp:ListItem Value="EUR">€ | EUR</asp:ListItem>
            <asp:ListItem Value="CHF">CHF</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
        <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" OnClick="ButtonCancel_Click" />
    </div>
    <div class="ux_cm_right">
        <asp:Label ID="Label5" runat="server" CssClass="ft_cmsheading1" Text="Location"></asp:Label>
        <br />
        <div class="ux_scroll">
            <asp:Panel ID="CheckBoxList2" runat="server">
            </asp:Panel>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="ft_cmsheading1" Text="Contract Type"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="ft_black" RepeatLayout="Flow">
            <asp:ListItem Value="3000">Permanent</asp:ListItem>
            <asp:ListItem Value="3001">Temporary</asp:ListItem>
            <asp:ListItem Value="3002">Contract</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="ft_cmsheading1" Text="Hours"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList7" runat="server" CssClass="ft_black" RepeatLayout="Flow">
            <asp:ListItem Value="3003">Full Time</asp:ListItem>
            <asp:ListItem Value="3004">Part Time</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label8" runat="server" CssClass="ft_cmsheading1" Text="Experience"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList8" runat="server" CssClass="ft_black" RepeatLayout="Flow">
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="ft_cmsheading1" Text="Categories"></asp:Label>
        <br />
        <div class="ux_scroll">
            <asp:Panel ID="CheckBoxList1" runat="server">
            </asp:Panel>
        </div>
        <asp:Label ID="Label16" runat="server" CssClass="ft_cmsheading1" Text="Sectors"></asp:Label>
        <br />
        <div class="ux_scroll">
            <asp:Panel ID="CheckBoxList4" runat="server">
            </asp:Panel>
        </div>
        <asp:Label ID="Label17" runat="server" CssClass="ft_cmsheading1" Text="Postcodes"></asp:Label>
        <br />
        <div class="ux_scroll">
            <asp:Panel ID="CheckBoxList5" runat="server">
            </asp:Panel>
        </div>
        <asp:Label ID="Label10" runat="server" CssClass="ft_cmsheading1" Text="Salary"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList6" runat="server" CssClass="ft_black" RepeatLayout="Flow">
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label18" runat="server" CssClass="ft_cmsheading1" Text="Education"></asp:Label>
        <br />
        <div class="ux_scroll">
            <asp:CheckBoxList ID="CheckBoxList9" runat="server" CssClass="ft_black" RepeatLayout="Flow">
            </asp:CheckBoxList>
        </div>
        <asp:Label ID="Label19" runat="server" CssClass="ft_cmsheading1" Text="Career Level"></asp:Label>
        <br />
        <div class="ux_scroll">
            <asp:CheckBoxList ID="CheckBoxList10" runat="server" CssClass="ft_black" RepeatLayout="Flow">
            </asp:CheckBoxList>
        </div>

        <br />
        <br />
        <br />
    </div>
</asp:Content>
