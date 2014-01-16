<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalaryQuestions.aspx.cs"
    Inherits="JB.SalaryCalc.SalaryQuestions" MasterPageFile="~/Job.Master" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <script src="/scripts/jqueryvx.js" type="text/javascript"></script>
    <link href="/styles/pheonixs1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
        <div class="ft_whitebd">
            Salary Calculator
        </div>
    </div>
    <div class="boxcorner">
        <asp:Label ID="Label2" runat="server" Text="Think you are underpaid!!! Please fill in the following to help us calculate your salary."
            CssClass="ft_backhighh1"></asp:Label>
        <!-- main contents-->
        <div class="pdrleft">
            <br />
            <br />
        </div>
        <div class="pdrleft">
            <div class="ft_notify">
                <asp:Label ID="LabelNotify" runat="server" Text=""></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_fixx4">
            </div>
            <img alt="one" src="/images/nm_one.gif" />
            <asp:Label ID="Label3" runat="server" Text=" Please select your current occupation or choose other if not listed below."
                CssClass="mainfnt"></asp:Label>
            <br />
            <asp:DropDownList ID="Occupationlist" runat="server" CssClass="comboSts padding2">
            </asp:DropDownList>
            <br />
            &nbsp;<asp:Label ID="Label10" runat="server" Text="Other" CssClass="mainfnt"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox3" runat="server" CssClass="TextboxSts" placeholder="if not in list type here, e.g. CEO"
                MaxLength="200"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="two" src="/images/nm_two.gif" />
            <asp:Label ID="Label4" runat="server" Text="
         Have you been offered a position?
        "
                CssClass="mainfnt"></asp:Label>
            <br />
            <asp:DropDownList ID="positionoffer" runat="server" CssClass="comboSts padding2">
                <asp:ListItem Value="1">Yes</asp:ListItem>
                <asp:ListItem Value="0">No</asp:ListItem>
            </asp:DropDownList>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="three" src="/images/nm_three.gif" />
            <asp:Label ID="Label5" runat="server" Text=" Please list the salary range you have been offered or looking for."
                CssClass="mainfnt"></asp:Label>
            <br />
            <asp:DropDownList ID="SalaryRange" runat="server" CssClass="comboSts padding2">
                <asp:ListItem Value="10000">0-10000</asp:ListItem>
                <asp:ListItem Value="20000">10000-20000</asp:ListItem>
                <asp:ListItem Value="30000">20000-30000</asp:ListItem>
                <asp:ListItem Value="40000">30000-40000</asp:ListItem>
                <asp:ListItem Value="50000">40000-50000</asp:ListItem>
                <asp:ListItem Value="50000">50000+</asp:ListItem>
            </asp:DropDownList>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="four" src="/images/nm_four.gif" />
            <asp:Label ID="Label6" runat="server" Text=" How many years expereince have you gained from your old jobs"
                CssClass="mainfnt"></asp:Label>
            <br />
            <asp:DropDownList ID="Experienceyears" runat="server" CssClass="comboSts padding2">
                <asp:ListItem Value="1">1 Year</asp:ListItem>
                <asp:ListItem Value="2">2 Year</asp:ListItem>
                <asp:ListItem Value="3">3 Year</asp:ListItem>
                <asp:ListItem Value="4">4 Year</asp:ListItem>
                <asp:ListItem Value="5">5 Year</asp:ListItem>
                <asp:ListItem Value="10">10 Year</asp:ListItem>
                <asp:ListItem Value="11">10+ Year</asp:ListItem>
            </asp:DropDownList>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="five" src="/images/nm_five.gif" />
            <asp:Label ID="Label7" runat="server" Text=" What is the highest level of education that you have received"
                CssClass="mainfnt"></asp:Label>
            <br />
            <asp:DropDownList ID="HighestEducation" runat="server" CssClass="comboSts padding2">
                <asp:ListItem>GCSE</asp:ListItem>
                <asp:ListItem>A/O Level</asp:ListItem>
                <asp:ListItem>Bachelors Some Uni</asp:ListItem>
                <asp:ListItem>Higher Education Diploma</asp:ListItem>
                <asp:ListItem>Post Grad Diploma</asp:ListItem>
                <asp:ListItem>Masters Some Uni</asp:ListItem>
                <asp:ListItem>Phd</asp:ListItem>
                <asp:ListItem>Post Doctoral</asp:ListItem>
            </asp:DropDownList>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="six" src="/images/nm_six.gif" />
            <asp:Label ID="Label8" runat="server" Text=" Was this education gained in EU or outside EU"
                CssClass="mainfnt"></asp:Label>
            <br />
        </div>
        <div class="pdrleft">
            <asp:DropDownList ID="Educationcountry" runat="server" CssClass="comboSts padding2">
                <asp:ListItem Value="1">EU</asp:ListItem>
                <asp:ListItem Value="0">Non-EU</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label9" runat="server" Text="If no where was this gained?" CssClass="mainfnt"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox2" runat="server" CssClass="TextboxSts" placeholder="if not EU type here, e.g. India"
                MaxLength="200"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="seven" src="/images/nm_seven.gif" />
            <asp:Label ID="Label11" runat="server" Text="Label" CssClass="mainfnt"> Where were you working before?</asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="TextboxSts" placeholder="please type here, e.g. Emap"
                MaxLength="200"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
        </div>
        <div class="pdrleft">
            <img alt="eight" src="/images/nm_eight.gif" />
            <asp:Label ID="Label12" runat="server" Text="Label" CssClass="mainfnt"> Where are you looking to work?</asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="TextboxSts" placeholder="Preferable company, e.g. ZARA"
                MaxLength="200"></asp:TextBox>
            <div class="dv_fix">
            </div>
            <br />
            <div class="ln_ccc">
            </div>
            <br />
            <div class="dv_fix">
            </div>
            <asp:Button ID="Button1" runat="server" Text="Calculate Salary" CssClass="button"
                OnClick="Button1Click" />
            <br />
        </div>
        <br />
    </div>
</asp:Content>
