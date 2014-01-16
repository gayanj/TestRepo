<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="ResExperience.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.ResExperience" %>

<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="http://localhost:2551/styles/pheonixgrid.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="Work Experience"
            CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Please use Add button after filling in work details, these may be past employers
        </div>
    </div>
    <div class="time_right">
        <div class="resume_left">
            <asp:Label ID="Label1" runat="server" Text="Company Name" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                ControlToValidate="ResSchool" CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResSchool" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label29" runat="server" Text="Job Title" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="ResDegree" CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResDegree" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label30" runat="server" Text="Start Date" CssClass="ft_black"></asp:Label>
            <br />
            <asp:TextBox ID="ResStartDate1" runat="server" CssClass="cn_txtbox" Width="50px"></asp:TextBox>
            <asp:TextBox ID="ResStartDate2" runat="server" CssClass="cn_txtbox" Width="50px"></asp:TextBox>
            <asp:TextBox ID="ResStartDate3" runat="server" CssClass="cn_txtbox" Width="50px"></asp:TextBox>
            <br />
            <asp:Label ID="Label31" runat="server" Text="End Date" CssClass="ft_black"></asp:Label>
            <br />
            <asp:TextBox ID="ResEndDate1" runat="server" CssClass="cn_txtbox" Width="50px"></asp:TextBox>
            <asp:TextBox ID="ResEndDate2" runat="server" CssClass="cn_txtbox" Width="50px"></asp:TextBox>
            <asp:TextBox ID="ResEndDate3" runat="server" CssClass="cn_txtbox" Width="50px"></asp:TextBox>
            <br />
            <asp:Label ID="Label28" runat="server" Text="Description" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                ControlToValidate="ResDesc" CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResDesc" runat="server" CssClass="cn_txtbox" Height="53px" TextMode="MultiLine"
                Width="250px"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonAdd" runat="server" Text="Add" CssClass="button" OnClick="ButtonAdd_Click" />
            <asp:Button ID="ButtonUpdate" runat="server" Text="Update" CssClass="button" Visible="false"
                OnClick="ButtonUpdate_Click" />
            <br />
        </div>
        <div class="resume_right">
            <div class="tb_headtwo">
                <asp:Label ID="Label2" runat="server" Text="Live Preview"></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_444">
            </div>
            <div class="dv_fix">
            </div>
            <br />
            <div class="w30">
                <asp:Label ID="Label3" runat="server" Text="Company Name" CssClass="ft_blackbd"></asp:Label>
            </div>
            <div class="w40">
                <asp:Label ID="Label4" runat="server" Text="Job Title" CssClass="ft_blackbd"></asp:Label>
            </div>
            <div class="w10">
                <asp:Label ID="Label5" runat="server" Text="Actions" CssClass="ft_blackbd"></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_ccc">
            </div>

            <asp:GridView ID="GridExperience" runat="server" AutoGenerateColumns="False" DataKeyNames="id_res_experience"
                ShowHeader="False" OnRowCommand="GridExperience_RowCommand" OnRowDeleting="GridExperience_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="School">
                        <ItemTemplate>
                            <div class="w30">
                                <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("rCompany") %>'></asp:Label>
                            </div>
                            <div class="w40">
                                <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("rJobTitle") %>'></asp:Label>
                            </div>
                            <div class="w10">
                                <asp:LinkButton ID="LinkButton1" CssClass="ft_bluelink" runat="server" CommandName="Edit"
                                    CommandArgument='<%#Eval("id_res_experience") %>' CausesValidation="false">Edit</asp:LinkButton>
                            </div>
                            <div class="w10">
                                <asp:LinkButton ID="LinkButton2" CssClass="ft_bluelink" runat="server" CommandName="Delete"
                                    CommandArgument='<%#Eval("id_res_experience") %>' CausesValidation="false">Remove</asp:LinkButton>
                            </div>
                            <div class="dv_fix">
                            </div>
                            <div class="ln_dotted">
                            </div>
                            <div class="dv_fix">
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
        <div class="dv_fix">
        </div>
        <div class="resume_center">
            <br />
            <asp:Label ID="Label6" runat="server" Text="OR" CssClass="ft_blackbd"></asp:Label>
            <br />
            <br />
            <asp:Button ID="ButtonSave" runat="server" Text="Continue to References" CausesValidation="false" CssClass="button" OnClick="ButtonSave_Click" />
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
