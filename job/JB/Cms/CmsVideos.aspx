<%@ Page Title="" Language="C#" MasterPageFile="~/Cms/Cms.Master" AutoEventWireup="true"
    CodeBehind="CmsVideos.aspx.cs" Inherits="JB.Cms.CmsVideos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Labelheaddetail" runat="server" Text="Videos" CssClass="ft_cmsheading1"></asp:Label>
    <div class="ln_dotccc">
    </div>

    <div class="dv_fix"></div>
    <div class="ux_gridheader">
        <div class="w10">
            <label class="ft_white">
                ID JOBS
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                JOB TITLE
            </label>
        </div>
        <div class="w20">
            <label class="ft_white">
                VIDEO TITLE
            </label>
        </div>
        <div class="w30">
            <label class="ft_white">
                VIDEO URL
            </label>
        </div>
        <div class="w10">
            <label class="ft_white">
                ENTERED
            </label>
        </div>
    </div>
    <div class="dv_fix"></div>

    <asp:GridView AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="idtb_videos"
        GridLines="None" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging"
        PageSize="10" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="w10">
                        <asp:Label ID="Label3" runat="server" CssClass="ft_black" Text='<%# Bind("idjobs") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label1" runat="server" CssClass="ft_black" Text='<%# Bind("stitle") %>'></asp:Label>
                    </div>
                    <div class="w20">
                        <asp:Label ID="Label2" runat="server" CssClass="ft_black" Text='<%# Bind("video_title") %>'></asp:Label>
                    </div>
                    <div class="w30">
                        <asp:Label ID="Label4" runat="server" CssClass="ft_black" Text='<%# Bind("video_url") %>'></asp:Label>
                    </div>
                    <div class="w10">
                        <asp:Label ID="Label5" runat="server" CssClass="ft_black" Text='<%# Bind("dtentered","{0:d}") %>'></asp:Label>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("idtb_videos", "CmsDelVideo.aspx?VideoId={0}") %>'
                            Text="Delete" CssClass="ft_bluelink">
                        </asp:HyperLink>
                    </div>
                    <div class="w5">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%# Eval("idtb_videos", "CmsEditVideo.aspx?VideoId={0}") %>'
                            Text="Edit" CssClass="ft_bluelink"></asp:HyperLink>
                    </div>
                    <div class="dv_fix">
                    </div>
                    <div class="ln_dotted">
                    </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <PagerStyle CssClass="PagerStyle" />
    </asp:GridView>
</asp:Content>
