<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Fix1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">資訊中心提醒您：請修電腦前，請確認資料是否皆已備份完成。</p>
        <p><a href="http://163.25.114.38/addcomfirm.aspx" class="btn btn-primary btn-lg">備份方法 &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>維修現況</h2>
            <p>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="createtime" HeaderText="createtime" SortExpression="createtime" />
                        <asp:BoundField DataField="caseType" HeaderText="caseType" SortExpression="caseType" />
                        <asp:BoundField DataField="assetID" HeaderText="assetID" SortExpression="assetID" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [createtime], [caseType], [assetID] FROM [case] ORDER BY [createtime]"></asp:SqlDataSource>
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>電腦維修小幫手</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://163.25.114.38/solution.aspx">請參考 &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
