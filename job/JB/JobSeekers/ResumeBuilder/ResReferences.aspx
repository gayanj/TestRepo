<%@ Page Title="" Language="C#" MasterPageFile="~/Jobseekers/Candidates.Master" AutoEventWireup="true"
    CodeBehind="ResReferences.aspx.cs" Inherits="JB.Jobseekers.ResumeBuilder.ResReferences" %>


<asp:Content ID="Content1" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="/styles/pheonixgrid.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="cn_header">
        <asp:Label ID="Label27" runat="server" Text="References" CssClass="ft_white"></asp:Label>
    </div>
    <br />
    <div class="time_left">
        <div class="ft_black">
            Please use Add button after filling in details to see live previews of qualifications
            on right
        </div>
    </div>
    
    <div class="time_right">
        <div class="resume_left">
            <asp:Label ID="Label33" runat="server" Text="Reference Type" CssClass="ft_black"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropdwn1" Width="250px">
                <asp:ListItem Selected="True" Value="0">Personal</asp:ListItem>
                <asp:ListItem Value="1">Business</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="First Name" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ResFirstName"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResFirstName" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label29" runat="server" Text="Last Name" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ResLastName"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResLastName" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label30" runat="server" Text="Email" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ResEmail"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResEmail" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label31" runat="server" Text="Local Phone" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ResLocalPhone"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResLocalPhone" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label32" runat="server" Text="Mobile Phone" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ResMobilePhone"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResMobilePhone" runat="server" CssClass="cn_txtbox" Width="250px"></asp:TextBox>
            <br />
            <asp:Label ID="Label28" runat="server" Text="Address" CssClass="ft_black"></asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="ResAddress"
                CssClass="ft_red" ErrorMessage="X"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="ResAddress" runat="server" CssClass="cn_txtbox" Height="53px" TextMode="MultiLine"
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
                <asp:Label ID="Label3" runat="server" Text="First Name" CssClass="ft_blackbd"></asp:Label>
            </div>
            <div class="w40">
                <asp:Label ID="Label4" runat="server" Text="Last Name" CssClass="ft_blackbd"></asp:Label>
            </div>
            <div class="w10">
                <asp:Label ID="Label5" runat="server" Text="Actions" CssClass="ft_blackbd"></asp:Label>
            </div>
            <div class="dv_fix">
            </div>
            <div class="ln_ccc">
            </div>
            <asp:GridView ID="Gridreference" runat="server" AutoGenerateColumns="False" DataKeyNames="id_res_reference"
                ShowHeader="False" OnRowCommand="GridReference_RowCommand" OnRowDeleting="GridReference_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="School">
                        <ItemTemplate>
                            <div class="w30">
                                <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("rfirstname") %>'></asp:Label>
                            </div>
                            <div class="w40">
                                <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("rlastname") %>'></asp:Label>
                            </div>
                            <div class="w10">
                                <asp:LinkButton ID="LinkButton1" CssClass="ft_bluelink" runat="server" CommandName="Edit"
                                    CommandArgument='<%#Eval("id_res_reference") %>' CausesValidation="false">Edit</asp:LinkButton>
                            </div>
                            <div class="w10">
                                <asp:LinkButton ID="LinkButton2" CssClass="ft_bluelink" runat="server" CommandName="Delete"
                                    CommandArgument='<%#Eval("id_res_reference") %>' CausesValidation="false">Remove</asp:LinkButton>
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
            <asp:Button ID="ButtonSave" runat="server" Text="Continue" CausesValidation="false"
                CssClass="button" OnClick="ButtonSave_Click" />
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>
