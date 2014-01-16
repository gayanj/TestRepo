<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="JobQuestions.aspx.cs" Inherits="JB.Recruiters.Jobquestions" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label14" runat="server" CssClass="ft_white" Text="Post Jobs"></asp:Label>
    </div>
    <div class="bg_black">
        <div class="ft_white">
            Step 3 of 3
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <div id="rc_qsmid">
        <asp:ScriptManager ID="ScriptManager1" runat="server" ScriptMode="Release">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="LabelChangesPending" runat="server" Visible="False">
                    <div class="qs_notify">
                        <div class="dv_shadowa1">
                            <div class="ft_notify">
                                <asp:Label ID="LabelChangeNotify" runat="server" Text="Notification: You have pending changes, please save them."></asp:Label>
                            </div>
                        </div>
                    </div>
                </asp:Panel>
                <br />
                <asp:LinkButton ID="LinkButtonAddQuestion" runat="server" CssClass="ft_bluelink"
                    OnClick="LinkButtonAddQuestion_Click">Add a new Question &gt;</asp:LinkButton>
                <asp:Panel ID="PanelQuestions" runat="server">
                </asp:Panel>
                <div class="dv_fix">
                </div>
                <br />
                <asp:Panel ID="PanelAddQuestions" runat="server" Visible="false">
                    <asp:Label ID="LabelQID" runat="server" Text="Question:" CssClass="ft_black"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxQuestion" runat="server" CssClass="cn_txtbox" Width="300px"></asp:TextBox>
                    <br />
                    <asp:Label ID="LabelAID" runat="server" Text="Answer:" CssClass="ft_black"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxAnswer" runat="server" CssClass="cn_txtbox"></asp:TextBox>
                    <br />
                    <asp:LinkButton ID="LinkButtonSave" runat="server" CssClass="ft_bluelink" OnClick="LinkButtonSave_Click">Save</asp:LinkButton>
                    <asp:LinkButton ID="LinkButtonCancel" runat="server" CssClass="ft_bluelink" OnClick="LinkButtonCancel_Click">Cancel</asp:LinkButton>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Save and Continue" CssClass="button" OnClick="Button1_Click" />
    </div>
</asp:Content>
