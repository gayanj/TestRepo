<%@ Page Title="" Language="C#" MasterPageFile="~/Recruiters/Recruiters.Master" AutoEventWireup="true"
    CodeBehind="RecHome.aspx.cs" Inherits="JB.Recruiters.Rechome" %>

<asp:Content ID="Content3" ContentPlaceHolderID="sitepref" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="rc_header">
        <asp:Label ID="Label2" runat="server" Text="Recruiter Dashboard" CssClass="ft_white"></asp:Label>
    </div>
    <div class="dv_fix">
    </div>
    <!-- zoom level adjustment -->
    <div id="zoomslevel">
        <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text="zoom level"></asp:Label>
        <asp:DropDownList ID="zoomer" CssClass="dropdownrec" runat="server" AutoPostBack="true">
            <asp:ListItem Selected="True">400</asp:ListItem>
            <asp:ListItem>500</asp:ListItem>
            <asp:ListItem>600</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="dv_fix">
    </div>
    <div class="time_left">
        <div class="ft_black">
            Here you can use multiple charts to display the metrics you want via graphs</div>
    </div>
    <div class="time_right">
        <!-- charts start -->
        <div class="divchartone">
            <asp:Label ID="Label3" runat="server" CssClass="ft_backhighh1" Text="Job views"></asp:Label>
            <br />
            <asp:Chart ID="Chart1" runat="server" Height="200px" BackColor="Silver" BackGradientStyle="TopBottom"
                BorderlineWidth="0" Palette="Chocolate">
                <Series>
                    <asp:Series Name="Series1" ChartType="Column">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <div class="divchartone">
            <asp:Label ID="Label1" runat="server" CssClass="ft_backhighh1" Text="Job Applications made by candidates"></asp:Label>
            <br />
            <asp:Chart ID="jobapps" runat="server" Height="200px" BackColor="Silver" BackGradientStyle="TopBottom"
                BorderlineWidth="0" Palette="Grayscale">
                <Series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
        <div class="dv_fix">
        </div>
        <br />
        <div class="divchartone">
            <asp:Label ID="Label4" runat="server" CssClass="ft_backhighh1" Text="Jobs posted by you"></asp:Label>
            <br />
            <asp:Chart ID="jobpostedview" runat="server" Height="200px" BackColor="Silver" BackGradientStyle="TopBottom"
                BorderlineWidth="0" Palette="Excel">
                <Series>
                    <asp:Series Name="Series1">
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
        </div>
    </div>
    <div class="dv_fix">
    </div>
    <br />
    <br />
</asp:Content>