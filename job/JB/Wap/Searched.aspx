<%@ Page Title="" Language="C#" MasterPageFile="~/wap/wap.Master" AutoEventWireup="true"
    CodeBehind="Searched.aspx.cs" Inherits="JB.wap.Searched" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="m_pagewrap">
        <div class="m_searchcover">
            <asp:TextBox ID="searchtext" CssClass="m_textboxmain" AutoCompleteType="None" runat="server"
                MaxLength="255"></asp:TextBox>
            <div class="searchedl3">
                <asp:Button ID="searchbutton" CssClass="ux_wpsearchbutton" runat="server" Text="Search" OnClick="searchbutton_Click" />
            </div>
        </div>
        <br />
        <asp:Label ID="LabelJobsFound" runat="server" Text="" Visible="false" CssClass="m_ft_blue"></asp:Label>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="JobGrid" runat="server" AutoGenerateColumns="False" BorderStyle="None" GridLines="None" ShowHeader="False" Width="100%">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# String.Format("JobApplication.aspx?jobid={0}&title={1}", Eval("idjobs"), Eval("sTitle")).Replace(" ", "-").Replace("--", "-").Replace("--", "-") %>'
                                    CssClass="m_ft_blue" Text='<%# Bind("sTitle") %>'></asp:HyperLink>
                                <div class="m_ft_gray">
                                    <asp:Label ID="Labeldadvert" runat="server" Text="Posted:"></asp:Label>
                                    &nbsp;<asp:Label ID="Labeldadvertout" runat="server" Text='<%# Bind("dtEnteredDate","{0:dd/M/yyyy}") %>'></asp:Label>
                                    &nbsp;<asp:Label ID="Label12" runat="server" Text="| Salary:"></asp:Label>
                                    &nbsp;<asp:Label ID="Label4" runat="server" Text='<%# Bind("sSalaryText") %>'></asp:Label>
                                    &nbsp;| &nbsp;<asp:Label ID="Label17" runat="server" Text="Recruiter: "></asp:Label>
                                    <asp:Label ID="Label22" runat="server" Text='<%# Bind("srecruitername") %>'></asp:Label>
                                </div>
                                <asp:Label ID="Label2" CssClass="m_ft_black" runat="server" Text='<%# Bind("sShortDescription") %>'></asp:Label>
                                <div class="m_dv_fix">
                                </div>
                                <br />
                                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl='<%# String.Format("JobApplication.aspx?jobid={0}&title={1}", Eval("idjobs"), Eval("sTitle")).Replace(" ", "-").Replace("--", "-").Replace("--", "-") %>'
                                    Text="Apply" CssClass="m_button"></asp:HyperLink>
                                <div class="m_dv_fix">
                                </div>
                                <br />
                                <div class="m_ln_ccc">
                                </div>
                                <br />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <asp:Button ID="PageMore" runat="server" Visible="false" Text="More" OnClick="PageMore_Click" CssClass="ux_wpsearchbutton" />

                <div class="ux_pageloader">
                    <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="UpdatePanel1"
                        DisplayAfter="1">
                        <ProgressTemplate>
                            <label for="LoadingIndicator" class="m_ft_black">Loading...</label>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
    </div>
</asp:Content>
