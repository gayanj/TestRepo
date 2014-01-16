<%@ Page Title="" Language="C#" MasterPageFile="~/Facebook/Facebook.Master" AutoEventWireup="true" CodeBehind="SearchJobs.aspx.cs" Inherits="JB.Facebook.SearchJobs" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="Scr1" ScriptMode="Release" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="rightpan">
                <div id="jobform">
                    <div class="ux_top">
                        <div class="ux_innershim">
                            <br />
                            <asp:TextBox ID="TextBox1" runat="server" Text="e.g. designer"></asp:TextBox>
                            <asp:TextBoxWatermarkExtender ID="Textender1" runat="server" Enabled="True" TargetControlID="searchtext"
                                WatermarkCssClass="dfttbsearchbxwme" WatermarkText="Job Title, e.g, manager">
                            </asp:TextBoxWatermarkExtender>
                            <label class="afont">in</label>
                            <asp:TextBox ID="TextBox2" runat="server" Text="Location"></asp:TextBox>
                            <asp:TextBoxWatermarkExtender ID="TExtender2" runat="server" Enabled="True" TargetControlID="searchtext"
                                WatermarkText="Location, e.g London">
                            </asp:TextBoxWatermarkExtender>
                            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
                            <br />
                            <br />
                        </div>
                    </div>
                    <div class="ux_innershim">
                        <!-- sorter -->
                        <div class="ux_bg">
                            <asp:Label ID="LabelTotal" runat="server" CssClass="afontbold" Text=""></asp:Label>
                        </div>
                        <asp:Label ID="LabelJobsFound" runat="server" Text="" Visible="false" CssClass="afont"></asp:Label>
                        <!-- job grid -->
                        <asp:GridView ID="JobGrid" runat="server" Showux_header="False" AutoGenerateColumns="False" GridLines="None">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <div class="ux_jobdes">
                                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# GetRedir(Eval("stitle"), Eval("idjobs")) %>'
                                                Text='<%# Bind("stitle") %>' CssClass="h1"></asp:HyperLink>
                                            <br />
                                            <asp:Label ID="LabelDesc" runat="server" CssClass="afontgray" Text='<%# Bind("collect") %>'></asp:Label>
                                            <br />
                                            <asp:Label ID="LabelHeading" runat="server" CssClass="afont" Text='<%# Bind("sshortdescription") %>'></asp:Label>
                                            <br />
                                            <br />
                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>

                        <asp:Button ID="PageMore" runat="server" Visible="false" Text="More" OnClick="PageMore_Click" CssClass="ux_expand" />
                        <div class="ux_pageloader">
                            <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel1"
                                DisplayAfter="1">
                                <ProgressTemplate>
                                    <label for="LoadingIndicator" class="afont">Loading...</label>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>
                        <br />
                        <br />
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
