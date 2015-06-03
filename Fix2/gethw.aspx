<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Main.Master" CodeBehind="gethw.aspx.vb" Inherits="Fix2.gethw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:SqlDataSource ID="SqlDataSource_gethw" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" InsertCommand="INSERT INTO CaseFlow(CaseID, CaseStatus, HandleMan, HandleTime, GetAttach) VALUES (@caseid,'1',@handleman,getdate(),@getattach)" SelectCommand="SELECT [CaseID], [AssetID], [UserName] FROM [Case] WHERE ([CaseID] = @CaseID)">
                <InsertParameters>
                    <asp:ControlParameter ControlID="tbCaseID" Name="caseid" PropertyName="Text" />
                    <asp:SessionParameter Name="handleman" SessionField="Account" />
                    <asp:ControlParameter ControlID="lblAttach" Name="getattach" PropertyName="Text" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="tbCaseID" Name="CaseID" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            維修單號<asp:TextBox ID="tbCaseID" runat="server"></asp:TextBox>
            <asp:Button ID="btn_getCaseID" runat="server" Text="取得資料" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource_gethw">
                <Columns>
                    <asp:BoundField DataField="CaseID" HeaderText="請修案號" SortExpression="CaseID" />
                    <asp:BoundField DataField="AssetID" HeaderText="資產編號" SortExpression="AssetID" />
                    <asp:BoundField DataField="UserName" HeaderText="請修人" SortExpression="UserName" />
                </Columns>
            </asp:GridView>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    請稍候.......
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    其它配件：<br />
    <asp:CheckBoxList ID="cblAttach" runat="server">
        <asp:ListItem>電源線</asp:ListItem>
        <asp:ListItem>筆電袋</asp:ListItem>
        <asp:ListItem>特殊傳輸線</asp:ListItem>
        <asp:ListItem>光碟片</asp:ListItem>
        <asp:ListItem>螢幕線</asp:ListItem>
        <asp:ListItem>隨身硬碟</asp:ListItem>
    </asp:CheckBoxList>
    <br />
    其它：<asp:TextBox ID="tbOtherAttach" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblAttach" runat="server" Text="Attach" Visible="False"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="確認送件" />
</asp:Content>
