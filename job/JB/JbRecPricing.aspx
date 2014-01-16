<%@ Page Title="" Language="C#" MasterPageFile="~/Job.Master" AutoEventWireup="true"
    CodeBehind="JbRecPricing.aspx.cs" Inherits="JB.Jbrecpricing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptParser1" runat="server" ScriptMode="Release">
    </asp:ScriptManager>
    <div class="divsimpletop">
     
        <div class="ft_whitebd">
            Pricing guide</div>
             
    </div>
    <div class="boxcorner">
        <br />
        
        <div class="divadvback2">
            <!-- ad pack start here -->
            <asp:Label ID="Label1" runat="server" Text="Almost all of our adverts come in 'ad packs' "
                CssClass="ft_backhighh1"></asp:Label>
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <br />
        <!-- payment subcats -->
        <div class="adv_back1">
            <b>Standard job ad pack for £399</b><br />
            Listed for 30 days<br />
            Standard listing of jobs in search results
            <br />
            <br />
            <b>Silver job ad pack for £499</b><br />
            Listed for 30 days<br />
            Displays on right side of the search page<br />
            <br />
            <b>Platinum job ad pack for £599</b><br />
            Listed for 30 days<br />
            Displays on top of the search page<br />
            <br />
            <b>Recruiter of the week ad pack</b><br />
            Listed for 7 days<br />
            Displayed on home page<br />
            Call or email for pricing<br />
            <br />
            <b>All site banner ad pack</b>
            <br />
            Displayed for 30 days<br />
            Displayed with our logo i.e. fashionquadrant<br />
            Call or email for pricing<br />
            Runs almost throughout the website
        </div>
        <div class="adv_back1">
            <b>Login Silver job ad pack</b><br />
            Listed for 7 days<br />
            Your own branded customized banner ad on back of<br />
            login page<br />
            Call or email for pricing<br />
            <br />
            <b>Login micro job ad pack for £299</b><br />
            Listed for one week<br />
            Displays on micro popups on login page<br />
            <br />
            <strong>Home page stock bar ad pack for <b>£199</b>
                <br />
            </strong>Listed for one week<br />
            Displays on Home page under the banner<br />
            <br />
            <b>Recruiter sub sites</b>
            <br />
            Your own branded job board on our site<br />
            Fully customizeable look and feel to match your brand<br />
            All your jobs grouped togather under the same page<br />
            Add your own customized Site pages and articles<br />
            Contact us for pricing and availability<br />
        </div>
        <div class="adv_back1">
            <b>Customized campaigns</b><br />
            Run campaign created under your own customized<br />
            analytics account<br />
            Track URLS and KPI's<br />
            Contact us for pricing and availability<br />
            <br />
            <b>Single CV</b><br />
            Online acess to your online anywhere.<br />
            Formats available, .doc, .pdf, .html, rtf or jpeg.<br />
            <br />
            <b>Bulk purchase discounts available</b><br />
            Contact us via email or directly to get pricing for<br />
            bulk discounts, however they are limited to a certain<br />
            monthly quota.<br />
            <br />
            <b>Monthly pakages</b><br />
            Want to remove all the extra stuff, from your account,
            <br />
            then this is the best solution for you!<br />
            Payments made monthy and without any hassle, while<br />
            your campaigns run throughout the month<br />
            Acess is limited to fair usage of service<br />
            Contact pricing and availabilty.
        </div>
        <div class="dv_fix">
        </div>
        <div class="divadvback2">
            <div class="ft_silverh1">
                email us at: info@fashionquadrant.com
                <br />
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/images/img_checkout.gif"
                    OnClick="ImageButton1Click" /></div>
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <br />
         
    </div>
</asp:Content>